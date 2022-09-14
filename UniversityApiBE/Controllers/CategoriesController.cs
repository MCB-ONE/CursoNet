using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversityApiBE.Dtos.Categories;

namespace UniversityApiBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IGenericRepository<Category> _categoryRepository;
        private readonly IMapper _mapper;

        public CategoriesController(IGenericRepository<Category> categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<CategoryDto>>> GetCategoriesAll()
        {
                
            var categoriess = await _categoryRepository.GetAllAsync();

            return _mapper.Map<List<CategoryDto>>(categoriess);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CategoryDto>> GetCategory(int id)
        {
            var category = await _categoryRepository.GetByIdAsync(id);

            return _mapper.Map<CategoryDto>(category);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<CategoryDto>> PutCategory(int id, CategoryDto categoryDto)
        {
            if (id != categoryDto.Id)
            {
                return BadRequest("El id de la request y el id de la categoría a actualizar no coinciden");
            }

            categoryDto.UpdatedAt = DateTime.Now;
            categoryDto.UpdatedBy = categoryDto.Name;

            var result = await _categoryRepository.Update(_mapper.Map<Category>(categoryDto));

            if (result == 0)
            {
                throw new Exception("La categoria no se ha podido actualizar.");
            }

            var categoryUpdated = _mapper.Map<CategoryDto>(categoryDto);

            return Ok(categoryUpdated);
        }

        [HttpPost]
        public async Task<ActionResult<CategoryDto>> PostCategory(CategoryDto categoryDto)
        {
            var category = _mapper.Map<Category>(categoryDto);

            var result = await _categoryRepository.Add(category);

            if (result == 0)
            {
                throw new Exception("Error al crear la categoria");
            }



            return CreatedAtAction("GetCategory", new { id = category.Id }, category);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCategory(int id)
        {

            var result = await _categoryRepository.Delete(id);

            if (result == 0)
            {
                throw (new Exception($"No se a podido eliminar la categoria con id {id}"));

            }
            return NoContent();
        }
    }
}
