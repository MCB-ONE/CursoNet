﻿using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversityApiBE.Dtos.Categories;

namespace UniversityApiBE.Controllers
{
    public class CategoriesController : BaseApIController
    {
        private readonly IGenericService<Category> _categoryService;
        private readonly IMapper _mapper;

        public CategoriesController(IGenericService<Category> categoryRepository, IMapper mapper)
        {
            _categoryService = categoryRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<CategoryDto>>> GetCategoriesAll()
        {
                
            var categoriess = await _categoryService.GetAllAsync();

            return _mapper.Map<List<CategoryDto>>(categoriess);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CategoryDto>> GetCategory(int id)
        {
            var category = await _categoryService.GetByIdAsync(id);

            return _mapper.Map<CategoryDto>(category);
        }


        [HttpPut("{id}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Administrator")]
        public async Task<ActionResult<CategoryDto>> PutCategory(int id, CategoryDto categoryDto)
        {
            if (id != categoryDto.Id)
            {
                return BadRequest("El id de la request y el id de la categoría a actualizar no coinciden");
            }

            categoryDto.UpdatedAt = DateTime.Now;
            categoryDto.UpdatedBy = categoryDto.Name;

            var result = await _categoryService.Update(_mapper.Map<Category>(categoryDto));

            if (result == 0)
            {
                throw new Exception("La categoria no se ha podido actualizar.");
            }

            var categoryUpdated = _mapper.Map<CategoryDto>(categoryDto);

            return Ok(categoryUpdated);
        }

        [HttpPost]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Administrator")]
        public async Task<ActionResult<CategoryDto>> PostCategory(CategoryDto categoryDto)
        {
            var category = _mapper.Map<Category>(categoryDto);

            var result = await _categoryService.Add(category);

            if (result == 0)
            {
                throw new Exception("Error al crear la categoria");
            }



            return CreatedAtAction("GetCategory", new { id = category.Id }, category);
        }

        [HttpDelete("{id}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Administrator")]
        public async Task<ActionResult> DeleteCategory(int id)
        {

            var result = await _categoryService.Delete(id);

            if (result == 0)
            {
                throw (new Exception($"No se a podido eliminar la categoria con id {id}"));

            }
            return NoContent();
        }
    }
}
