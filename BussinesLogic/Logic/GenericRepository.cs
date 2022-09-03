using BussinesLogic.Data;
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

    }
}
