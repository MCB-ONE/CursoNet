
using BussinesLogic.Data;
using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BussinesLogic.Logic
{
    public class CoursesServices : GenericService<Course>, ICoursesServices
    {
        private readonly UniversityDBContext _context;
        private readonly ILogger<CoursesServices> _logger;

        public CoursesServices(UniversityDBContext context, ILogger<CoursesServices> logger) : base(context, logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<int> CreateCourseWhitCategories(Course course)
        {
            // Configurar loggings
            _logger.LogWarning($"{nameof(CoursesServices)} - {nameof(CreateCourseWhitCategories)} - Warning Level Log");
            _logger.LogError($"{nameof(CoursesServices)} - {nameof(CreateCourseWhitCategories)} - Error Level Log");
            _logger.LogCritical($"{nameof(CoursesServices)} - {nameof(CreateCourseWhitCategories)} - Critical Log Level");


            course.Categories.ForEach(cat => _context.Entry(cat).State = EntityState.Unchanged);

            //TODO: Agregar inserción index

            _context.Add(course);

            return await _context.SaveChangesAsync();
        }

        public async Task<List<Course>> FilterCoursesByCategory(int categoryId)
        {
            // Configurar loggings
            _logger.LogWarning($"{nameof(CoursesServices)} - {nameof(FilterCoursesByCategory)} - Warning Level Log");
            _logger.LogError($"{nameof(CoursesServices)} - {nameof(FilterCoursesByCategory)} - Error Level Log");
            _logger.LogCritical($"{nameof(CoursesServices)} - {nameof(FilterCoursesByCategory)} - Critical Log Level");

            var categoryExist = await _context.Categories.AnyAsync(c => c.Id == categoryId);

            if (!categoryExist)
                return null;


            var courses = await _context.Courses
                                .Include(c => c.Students)
                                .Include(c => c.Categories)
                                .Where(c => c.Categories.Any(x => x.Id ==   categoryId)).ToListAsync();
            

            return courses;
        }

        public async Task<List<Course>> FilterCoursesWhitoutIndex()
        {

            // Configurar loggings
            _logger.LogWarning($"{nameof(CoursesServices)} - {nameof(FilterCoursesWhitoutIndex)} - Warning Level Log");
            _logger.LogError($"{nameof(CoursesServices)} - {nameof(FilterCoursesWhitoutIndex)} - Error Level Log");
            _logger.LogCritical($"{nameof(CoursesServices)} - {nameof(FilterCoursesWhitoutIndex)} - Critical Log Level");

            return await _context.Courses
             .Where(c => c.Index == null)
             .Include(c => c.Categories).
             ToListAsync();


        }

        public async Task<int> UpdateCourse(int courseId, Course courseUpdated, List<int> newCategoriesIds)
        {
            // Configurar loggings
            _logger.LogWarning($"{nameof(CoursesServices)} - {nameof(UpdateCourse)} - Warning Level Log");
            _logger.LogError($"{nameof(CoursesServices)} - {nameof(UpdateCourse)} - Error Level Log");
            _logger.LogCritical($"{nameof(CoursesServices)} - {nameof(UpdateCourse)} - Critical Log Level");

            // Recuperamos registro a actualizar
            var courseDb = _context.Courses
                            .Include(c => c.Categories)
                            .Include(c => c.Index)
                            .FirstOrDefault(c => c.Id == courseId);


            if (courseDb == null)
            {
                throw new ArgumentNullException("entity");

            }


            // Actualizamos las props con las que llegan en la request no las relaciones
            _context.Entry(courseDb).CurrentValues.SetValues(courseUpdated);

            // Crear indice nuevo si el curso no tiene
            if (courseDb.Index == null && courseUpdated.Index != null)
            {
                _context.Indexes.Add(new Core.Entities.Index
                {
                    CourseId = courseUpdated.Index.CourseId,
                    List = courseUpdated.Index.List
                });

            }


            // Borrar indice actual o actualizar existente
            if (courseUpdated.Index == null && courseDb.Index != null)
            {
                var indexToRemove = await _context.Indexes.FirstOrDefaultAsync(i => i.CourseId == courseId);
                _context.Set<Core.Entities.Index>().Remove(indexToRemove);
                courseDb.Index = null;
            }
            else
            {
                // Actualizar indice existente si llegan nuevas propiedades
                courseDb.Index.List = courseUpdated.Index.List;
            }

            //Actualizar categorias
            if (newCategoriesIds.Count > 0)
            {
                var categoriesToRemove = courseDb.Categories.ToList();
                foreach (var catToRemove in categoriesToRemove)
                    courseDb.Categories.Remove(catToRemove);

                var catsToAdd = await _context.Categories
                    .Where(c => newCategoriesIds.Contains(c.Id))
                    .ToListAsync();
                foreach (var catToAdd in catsToAdd)
                    courseDb.Categories.Add(catToAdd);
            }
            else{
                var categoriesToRemove = courseDb.Categories.ToList();
                foreach (var catToRemove in categoriesToRemove)
                    courseDb.Categories.Remove(catToRemove);
            }


            return await _context.SaveChangesAsync();
        }
    }
}
