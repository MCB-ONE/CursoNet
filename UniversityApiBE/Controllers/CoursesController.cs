using AutoMapper;
using BussinesLogic.Data;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniversityApiBE.Services.Courses;
using UniversityApiBE.Dtos.Courses;
using UniversityApiBE.Error;

namespace UniversityApiBE.Controllers
{
    public class CoursesController : BaseApIController
    {
        private readonly IMapper _mapper;
        private readonly UniversityDBContext _context;
        private readonly ICoursesServices _coursesServices;
        public CoursesController(UniversityDBContext context, ICoursesServices coursesServices, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            _coursesServices = coursesServices;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CourseDto>>> GetAllCourses()
        {

            // Eager loading
            var courses = await _context.Courses
                          .Include(c => c.Categories)
                          .Include(c => c.Index)
                          .Include(c => c.Students)
                          .ToListAsync();

            var coursesDto = _mapper.Map<List<CourseDto>>(courses);

            return Ok(coursesDto);
        }

        [HttpGet("getCoursesByCategory/{categoryId}")]
        public async Task<ActionResult<IEnumerable<CourseDto>>> GetCoursesByCategory(int categoryId)
        {
            var courses = await _coursesServices.FilterCoursesByCategoryAsync(categoryId);

            if (courses == null)
                return NotFound();


            return _mapper.Map<List<CourseDto>>(courses);
        }

        [HttpGet("getCoursesWithoutIndex")]
        public async Task<ActionResult<IEnumerable<CourseDto>>> GetCoursesWithoutIndex()
        {
            var courses = await _coursesServices.FilterCoursesWhitoutIndexAsync();

            if (courses == null)
                return NotFound();


            return _mapper.Map<List<CourseDto>>(courses);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<CourseDto>> GetCourse(int id)
        {
            var course = await _context.Courses
                         .Include(c => c.Categories)
                         .Include(c => c.Index)
                         .Include(c => c.Students)
                         .FirstOrDefaultAsync(c => c.Id == id);

            if (course == null)
            {
                return NotFound(new CodeErrorResponse(404, $"Curso con id {id} no existe."));
            }

            return Ok(_mapper.Map<CourseDto>(course));
        }

        /*
         * Ruta para actualizar curso, datso, indice y categorias
         */

        [HttpPut("{id:int}")]
        public async Task<ActionResult<CourseDto>> UpdateCourse(int id, CourseUpdateDto dto)
        {
            // Recuperamos registro a actualizar
            var courseDb = _context.Courses
                            .Include(c => c.Categories)
                            .Include(c => c.Index)
                            .FirstOrDefault(c => c.Id == id);


            if (courseDb == null)
                return NotFound();

            // Actualizamos las props con las que llegan en la request no las relaciones
            _context.Entry(courseDb).CurrentValues.SetValues(dto);

            // Crear indice nuevo si el curso no tiene
            if (courseDb.Index == null)
            {
                _context.Indexes.Add(new Core.Entities.Index
                {
                    CourseId = dto.Index.CourseId,
                    List = dto.Index.List
                });

            }

            // Borrar indice actual o actualizar existente
            if (dto.Index == null)
            {
                var indexToRemove = await _context.Indexes.FirstOrDefaultAsync(i => i.CourseId == id);
                _context.Set<Core.Entities.Index>().Remove(indexToRemove);
                courseDb.Index = null;
            }
            else
            {
                // Actualizar indice existente si llegan nuevas propiedades
                courseDb.Index.List = dto.Index.List;
            }

            //Actualizar categorias
            if (dto.CategoriesIds != null)
            {
                var categoriesToRemove = courseDb.Categories.ToList();
                foreach (var catToRemove in categoriesToRemove)
                    courseDb.Categories.Remove(catToRemove);

                var catsToAdd = await _context.Categories
                    .Where(c => dto.CategoriesIds.Contains(c.Id))
                    .ToListAsync();
                foreach (var catToAdd in catsToAdd)
                    courseDb.Categories.Add(catToAdd);
            }

            //_context.Courses.Attach(courseDb);
            //_context.Entry(courseDb).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCourse), new { id = courseDb.Id }, _mapper.Map<CourseDto>(courseDb));
        }


        // Crear curso con categorias ya existentes
        [HttpPost]
        public async Task<ActionResult<CourseDto>> Post(CourseCreateDto courseCreateDto)
        {

            var course = _mapper.Map<Course>(courseCreateDto);

            course.Categories.ForEach(cat => _context.Entry(cat).State = EntityState.Unchanged);

            //TODO: Agregar inserción index

            _context.Add(course);

            await _context.SaveChangesAsync();

            return Ok(course.Id);

        }
    }
}
