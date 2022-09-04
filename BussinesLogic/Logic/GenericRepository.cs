﻿using BussinesLogic.Data;
using Core.Entities;
using Core.Interfaces;
using Core.Specifications;
using Microsoft.EntityFrameworkCore;

namespace BussinesLogic.Logic
{ 
    // Clse generica que implementa la interfaz del repositorio genérico
    public class GenericRepository<T> : IGenericRepository<T> where T: BaseEntity
    {
        private readonly UniversityDBContext _context;
        private DbSet<T> table = null;

        public GenericRepository(UniversityDBContext context)
        {
            _context = context;
        }

        //private bool EntitiExist(int id)
        //{
        //    return (_context.Users?.Any(entity => entity.Id == id)).GetValueOrDefault();
        //}

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {       
          return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);

        }

        public async Task<T> GetByIdWithSpecAsync(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).FirstOrDefaultAsync();
        }

        public async Task<IReadOnlyList<T>> GetAllIdWithSpecAsync(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).ToListAsync();
        }

        private IQueryable<T> ApplySpecification(ISpecification<T> spec)
        {
            return SpecificationEvaluator<T>.GetQuery(_context.Set<T>().AsQueryable(), spec);
        }

        public async Task<int> Add(T entity)
        {
            _context.Set<T>().Add(entity);
            return await _context.SaveChangesAsync();
             
        }

        public async Task<int> Update(T entity)
        {
            _context.Set<T>().Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;

            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int id)
        {
            T entity = await _context.Set<T>().FindAsync(id);

            _context.Set<T>().Remove(entity);

            return await _context.SaveChangesAsync();
        }


        public bool EntityExist(T entity, int id)
        {
            return (_context.Set<T>().Any(entity => entity.Id == id));
        }

        

        // DELETE: api/Users/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteUser(int id)
        //{
        //    if (_context.Users == null)
        //    {
        //        return NotFound();
        //    }
        //    var user = await _context.Users.FindAsync(id);
        //    if (user == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Users.Remove(user);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}


    }
}
