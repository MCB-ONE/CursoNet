using AutoMapper;
using BussinesLogic.Data;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniversityApiBE.Dtos.Indexes;

namespace UniversityApiBE.Controllers
{
    public class IndexController : BaseApIController
    {
        private readonly IMapper _mapper;
        private readonly IIndexesService _indexesService;
        public IndexController(IIndexesService indexesService, IMapper mapper)
        {
            _mapper = mapper;
            _indexesService = indexesService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<IndexDto>>> GetAllIndexes()
        {
            var indexes = await _indexesService.GetAllAsync();

            var indexesDto = _mapper.Map<List<IndexDto>>(indexes);

            return Ok(indexesDto);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<IndexDto>> GetIndexById(int id)
        {
            var index = await _indexesService.GetByIdAsync(id);

            var indexsDto = _mapper.Map<IndexDto>(index);

            return Ok(indexsDto);
        }

        [HttpGet("geIndexByCourseId{courseId:int}")]
        public async Task<ActionResult<IndexDto>> getIndexByCourseId(int courseId)
        {
            var index = await _indexesService.FilterIndexByCourse(courseId);

            if (index == null)
                return NotFound();

            return Ok(_mapper.Map<IndexDto>(index));
        }



    }
}
