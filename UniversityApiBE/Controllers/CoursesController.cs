using AutoMapper;
using BussinesLogic.Data;
using Core.Entities;
using Core.Interfaces;
using Core.Specifications.Courses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniversityApiBE.Dtos.Courses;
using UniversityApiBE.Error;

namespace UniversityApiBE.Controllers
{
    public class CoursesController : BaseApIController
    {
        private readonly IMapper _mapper;
        private readonly ICoursesServices _coursesServices;
        public CoursesController(ICoursesServices coursesServices, IMapper mapper)
        {
     
            _mapper = mapper;
            _coursesServices = coursesServices;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CourseDto>>> GetAllCourses()
        {

            var spec = new CourseFullSpecification();

            // Eager loading
            var courses = await _coursesServices.GetAllIdWithSpecAsync(spec);

            var coursesDto = _mapper.Map<List<CourseDto>>(courses);

            return Ok(coursesDto);
        }

        [HttpGet("getCoursesByCategory/{categoryId}")]
        public async Task<ActionResult<IEnumerable<CourseDto>>> GetCoursesByCategory(int categoryId)
        {
            var courses = await _coursesServices.FilterCoursesByCategory(categoryId);

            if (courses == null)
                return NotFound();


            return _mapper.Map<List<CourseDto>>(courses);
        }

        [HttpGet("getCoursesWithoutIndex")]
        public async Task<ActionResult<IEnumerable<CourseDto>>> GetCoursesWithoutIndex()
        {
            var courses = await _coursesServices.FilterCoursesWhitoutIndex();

            if (courses == null)
                return NotFound();


            return _mapper.Map<List<CourseDto>>(courses);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<CourseDto>> GetCourse(int id)
        {
            var spec = new CourseFullSpecification(id);
            var course = await _coursesServices.GetByIdWithSpecAsync(spec);

            if (course == null)
            {
                return NotFound(new CodeErrorResponse(404, $"Curso con id {id} no existe."));
            }

            return Ok(_mapper.Map<CourseDto>(course));
        }

        /*
         * Ruta para actualizar curso, datos, indice y categorias
         */

        [HttpPut("{id:int}")]
        public async Task<ActionResult<CourseDto>> UpdateCourse(int id, CourseUpdateDto dto)
        {

            if (id != dto.Id)
            {
                return BadRequest("El id de la request y el id del curso a actualizar no coinciden");
            }

            dto.UpdatedAt = DateTime.Now;
            dto.UpdatedBy = "Test";

            var newCategoriesIds = dto.CategoriesIds;

            var result = await _coursesServices.UpdateCourse(id, _mapper.Map<Course>(dto), newCategoriesIds);
            if(result == 0)
            {
                throw new Exception("El curso no se ha podido actualizar.");
            }

            return Ok(dto);
        }


        // Crear curso con categorias ya existentes
        [HttpPost]
        public async Task<ActionResult<CourseDto>> Post(CourseCreateDto courseCreateDto)
        {

            var course = _mapper.Map<Course>(courseCreateDto);

            var result = await _coursesServices.CreateCourseWhitCategories(course);

            if(result == 0)
            {
                return BadRequest();
            }

            return Ok(courseCreateDto);

        }
    }
}
