using BussinesLogic.Data;
using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BussinesLogic.Logic
{
    public class StudentsServices : GenericService<Student>, IStudentsService
    {
        private readonly UniversityDBContext _context;
        private readonly ILogger<StudentsServices> _logger;

        public StudentsServices(UniversityDBContext context, ILogger<StudentsServices> logger): base(context, logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<List<Student>> FilterStudentsByCourses(int courseId)
        {
            // Configurar loggings
            _logger.LogWarning($"{nameof(StudentsServices)} - {nameof(FilterStudentsByCourses)} - Warning Level Log");
            _logger.LogError($"{nameof(StudentsServices)} - {nameof(FilterStudentsByCourses)} - Error Level Log");
            _logger.LogCritical($"{nameof(StudentsServices)} - {nameof(FilterStudentsByCourses)} - Critical Log Level");

            var courseExist = await _context.Courses.AnyAsync(c => c.Id == courseId);

            if (!courseExist)
                return null;

            return await _context.Students
                .Include(s => s.Courses)
                .Where(s => s.Courses.Any(c => c.Id == courseId))
                .ToListAsync();
        }

        public async Task<List<Student>> FilterStudentsWithOutCourses()
        {
            // Configurar loggings
            _logger.LogWarning($"{nameof(StudentsServices)} - {nameof(UpdateStudent)} - Warning Level Log");
            _logger.LogError($"{nameof(StudentsServices)} - {nameof(UpdateStudent)} - Error Level Log");
            _logger.LogCritical($"{nameof(StudentsServices)} - {nameof(UpdateStudent)} - Critical Log Level");

            return await _context.Students
                         .Where(s => s.Courses.Count == 0)
                         .Include(s => s.Courses)
                         .ToListAsync();

        }

        public async Task<int> UpdateStudent(int studentId, Student studentUpdated, List<int> newCouresIds)
        {
            // Configurar loggings
            _logger.LogWarning($"{nameof(StudentsServices)} - {nameof(UpdateStudent)} - Warning Level Log");
            _logger.LogError($"{nameof(StudentsServices)} - {nameof(UpdateStudent)} - Error Level Log");
            _logger.LogCritical($"{nameof(StudentsServices)} - {nameof(UpdateStudent)} - Critical Log Level");


            var studentDb = await _context.Students
                            .Include(s => s.Courses)
                            .FirstOrDefaultAsync(c => c.Id == studentId);

            if (studentDb == null)
            {
                throw new ArgumentNullException("No se ha encontrado el estudiante a actualizar");
            }

            // Actualizamos las props con las que llegan en la request no las relaciones
            _context.Entry(studentDb).CurrentValues.SetValues(studentUpdated);

            if (newCouresIds.Count > 0)
            {
                // Eliminamos las relaciones actuales del registro de la bdd
                if(studentDb.Courses.Count > 0)
                {
                    var coursesToRemove = studentDb.Courses.ToList();
                    foreach (var oldCourse in coursesToRemove)
                        studentDb.Courses.Remove(oldCourse);
                }


                // Añadimos todas las relaciones que llegan des de el cliente
                var coursesToAdd = await _context.Courses
                    .Where(c => newCouresIds.Contains(c.Id))
                    .ToListAsync();
                if(coursesToAdd.Count == 0)
                {
                    throw new Exception("Hay Ids de los cursos a actualizar que no existen");
                }
                
                foreach (var courseToAdd in coursesToAdd)
                    studentDb.Courses.Add(courseToAdd);

            }
            else
            {
                var coursesToRemove = studentDb.Courses.ToList();
                foreach (var oldCourse in coursesToRemove)
                    studentDb.Courses.Remove(oldCourse);
            }

            return await _context.SaveChangesAsync();
        }



    }


}
