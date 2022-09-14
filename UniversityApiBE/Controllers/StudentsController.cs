using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Core.Entities;
using Core.Interfaces;
using UniversityApiBE.Dtos.Students;
using Core.Specifications.StudentSpecification;

namespace UniversityApiBE.Controllers
{
    public class StudentsController : BaseApIController
    {
        private readonly IGenericRepository<Student> _studentRepository;
        private readonly IMapper _mapper;

        public StudentsController(IGenericRepository<Student> studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<StudentDto>>> GetStudentsAll()
        {
            var spec = new StudentWithCoursesSpecification();

            var students = await _studentRepository.GetAllIdWithSpecAsync(spec);

            return _mapper.Map<List<StudentDto>>(students);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<StudentDto>> GetStudent(int id)
        {
            var spec = new StudentWithCoursesSpecification(id);
            var student = await _studentRepository.GetByIdWithSpecAsync(spec);

            return _mapper.Map<StudentDto>(student);
        }

        [HttpPut("UpdateStudentInformation/{id}")]
        public async Task<ActionResult<StudentUpdateDto>> UpdateStudentInformation(int id, StudentUpdateDto studentUpdateDto)
        {

            if (id != studentUpdateDto.Id)
            {
                return BadRequest("El id de la request y el id del estudiante a actualizar no coinciden");
            }

            studentUpdateDto.UpdatedAt = DateTime.Now;
            studentUpdateDto.UpdatedBy = studentUpdateDto.Name;

            var result = await _studentRepository.Update(_mapper.Map<Student>(studentUpdateDto));

            if (result == 0)
            {
                throw new Exception("El estudiante no se ha podido actualizar.");
            }


            return Ok(studentUpdateDto);
        }




        [HttpPost]
        public async Task<ActionResult<StudentDto>> PostStudent(StudentCreateDto studentCreateDto)
        {
            var student = _mapper.Map<Student>(studentCreateDto);

            var result = await _studentRepository.Add(student);

            if (result == 0)
            {
                throw new Exception("Error al crear el estudiante");
            }   

            return CreatedAtAction("GetStudent", new { id = student.Id }, student);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteStudent(int id)
        {

            var result = await _studentRepository.Delete(id);

            if (result == 0)
            {
                throw (new Exception($"No se a podido eliminar el estudiante con id {id}"));

            }
            return NoContent();
        }

    }
}
