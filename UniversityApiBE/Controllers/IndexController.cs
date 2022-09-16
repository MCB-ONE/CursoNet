using AutoMapper;
using BussinesLogic.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniversityApiBE.Dtos.Indexes;
using UniversityApiBE.Services.Indexes;

namespace UniversityApiBE.Controllers
{
    public class IndexController : BaseApIController
    {
        private readonly IMapper _mapper;
        private readonly UniversityDBContext _context;
        private readonly IIndexesService _indexesService;
        public IndexController(UniversityDBContext context, IIndexesService indexesService, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            _indexesService = indexesService;
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

        [HttpGet("geIndexByCourseId{courseId:int}")]
        public async Task<ActionResult<IndexDto>> getIndexByCourseId(int courseId)
        {
            var index = await _indexesService.FilterIndexByCourseAsync(courseId);

            if(index == null)
                return NotFound();  


            return Ok(_mapper.Map<IndexDto>(index));
        }



    }
}
