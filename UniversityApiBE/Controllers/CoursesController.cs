using AutoMapper;
using BussinesLogic.Data;
using Core.Entities;
using Core.Interfaces;
using Core.Specifications.Courses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniversityApiBE.Dtos.Courses;
using UniversityApiBE.Error;
using UniversityApiBE.Services;

namespace UniversityApiBE.Controllers
{
    public class CoursesController : BaseApIController
    {
        private readonly IMapper _mapper;
        private readonly UniversityDBContext _context;
        public CoursesController(UniversityDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
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

        [HttpPut("UpdateCourseCategories/{id:int}")]
        public async Task<ActionResult<CourseDto>> UpdateCourseCategories(int id, CourseUpdateDto dto)
        {
            // Recuperamos registro a actualizar
            var courseDb = _context.Courses
                            .Include(c => c.Categories)
                            .Include(c => c.Index).AsNoTracking()
                            .FirstOrDefault(c => c.Id == id);

            if (courseDb == null)
            {
                return NotFound();

            }

            // Actualizamos las props con las que llegan en la request no las relaciones
            _context.Entry(courseDb).CurrentValues.SetValues(dto);

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

            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCourse), new { id = courseDb.Id }, _mapper.Map<CourseDto>(courseDb));
        }

        [HttpPut("UpdateCourseIndex/{id:int}")]
        public async Task<ActionResult<CourseDto>> UpdateCourseIndex(int id, CourseUpdateDto dto)
        {
            // Recuperamos registro a actualizar
            var courseDb = _context.Courses
                            .Include(c => c.Categories).AsNoTracking()
                            .Include(c => c.Index)
                            .FirstOrDefault(c => c.Id == id);

            if (courseDb == null)
                return NotFound();


            if(courseDb.Index == null) {
                _context.Indexes.Add(new Core.Entities.Index
                {
                    Id = dto.Index.Id,
                    CourseId = dto.Index.CourseId,
                    List = dto.Index.List
                });
                courseDb.Index = new Core.Entities.Index
                {
                    Id = dto.Index.Id,
                    CourseId = dto.Index.CourseId,
                    List = dto.Index.List
                };
            }


            if (dto.Index == null)
            {
                var indexToRemove = _context.Indexes.FirstOrDefault(i => i.CourseId == id);
                _context.Set<Core.Entities.Index>().Remove(indexToRemove);
                courseDb.Index = null;
            }

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
