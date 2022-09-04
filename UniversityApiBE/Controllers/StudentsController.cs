using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Core.Entities;
using Core.Interfaces;

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
        public async Task<ActionResult<List<Student>>> GetStudentsAll()
        {
            var students = await _studentRepository.GetAllAsync();

            return Ok(students);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetStudentById(int id)
        {

            return await _studentRepository.GetByIdAsync(id);
        }

    }
}
