using AutoMapper;
using BussinesLogic.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniversityApiBE.Dtos.Indexes;

namespace UniversityApiBE.Controllers
{
    public class IndexController : BaseApIController
    {
        private readonly IMapper _mapper;
        private readonly UniversityDBContext _context;
        public IndexController(UniversityDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<IndexDto>>> GetAllIndexes()
        {
            var indexes = await _context.Indexes.ToListAsync();

            var indexesDto = _mapper.Map<List<IndexDto>>(indexes);

            return Ok(indexesDto);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<IndexDto>> GetIndexById(int id)
        {
            var index = await _context.Indexes.FirstOrDefaultAsync(i => i.Id == id);

            var indexsDto = _mapper.Map<IndexDto>(index);

            return Ok(indexsDto);
        }

    }
}
