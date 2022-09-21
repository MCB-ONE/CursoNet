using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Core.Entities;
using Core.Interfaces;
using UniversityApiBE.Dtos.Students;
using Core.Specifications.StudentSpecification;

namespace UniversityApiBE.Controllers
{
    public class StudentsController : BaseApIController
    {
        private readonly IStudentsService _studentService;
        private readonly IMapper _mapper;

        public StudentsController(IStudentsService studentService, IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<StudentDto>>> GetStudentsAll()
        {
            var spec = new StudentWithCoursesSpecification();

            var students = await _studentService.GetAllIdWithSpecAsync(spec);

            return _mapper.Map<List<StudentDto>>(students);
        }

        [HttpGet("getStudentsWhitoutCourses")]
        public async Task<ActionResult<List<StudentDto>>> GetStudentsWithoutCourses()
        {
            
            var students = await _studentService.FilterStudentsWithOutCourses();

            return _mapper.Map<List<StudentDto>>(students);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<StudentDto>> GetStudent(int id)
        {
            var spec = new StudentWithCoursesSpecification(id);
            var student = await _studentService.GetByIdWithSpecAsync(spec);
            if (student == null)
                return NotFound();

            return _mapper.Map<StudentDto>(student);
        }

        [HttpGet("GetStudentsByCourse/{courseId:int}")]
        public async Task<ActionResult<List<StudentDto>>> GetStudentsByCourse(int courseId)
        {
            
            var students = await _studentService.FilterStudentsByCourses(courseId);

            if(students == null)
                return NotFound();


            return _mapper.Map<List<StudentDto>>(students);
        }


        [HttpPut("UpdateStudent/{id}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Administrator")]
        public async Task<ActionResult<StudentUpdateDto>> UpdateStudent(int id, StudentUpdateDto studentUpdateDto)
        {

            if (id != studentUpdateDto.Id)
            {
                return BadRequest("El id de la request y el id del estudiante a actualizar no coinciden");
            }

            studentUpdateDto.UpdatedAt = DateTime.Now;
            studentUpdateDto.UpdatedBy = studentUpdateDto.Name;

            // Extraer array de ids de los nuevos cursos relacionados que llegan desde el cliente

            var newCouresIds = studentUpdateDto.CoursesId;


            var result = await _studentService.UpdateStudent(id, _mapper.Map<Student>(studentUpdateDto), newCouresIds);

            if (result == 0)
            {
                throw new Exception("El estudiante no se ha podido actualizar.");
            }

            return Ok(studentUpdateDto);
        }


        [HttpPost]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Administrator")]
        public async Task<ActionResult<StudentDto>> PostStudent(StudentCreateDto studentCreateDto)
        {
            var student = _mapper.Map<Student>(studentCreateDto);

            var result = await _studentService.Add(student);

            if (result == 0)
            {
                throw new Exception("Error al crear el estudiante");
            }   

            return CreatedAtAction("GetStudent", new { id = student.Id }, student);
        }

        [HttpDelete("{id}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Administrator")]
        public async Task<ActionResult> DeleteStudent(int id)
        {

            var result = await _studentService.Delete(id);

            if (result == 0)
            {
                throw (new Exception($"No se a podido eliminar el estudiante con id {id}"));

            }
            return NoContent();
        }

    }
}
