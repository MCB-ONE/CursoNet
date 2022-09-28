using BussinesLogic.Data;
using Core.Entities;
using Core.Interfaces;
using Core.Specifications;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BussinesLogic.Logic
{ 
    // Clse generica que implementa la interfaz del repositorio genérico
    public class GenericService<T> : IGenericService<T> where T: BaseEntity
    {
        private readonly UniversityDBContext _context;
        private readonly ILogger<GenericService<T>> _logger;
        private UniversityDBContext context;

        public GenericService(UniversityDBContext context, ILogger<GenericService<T>> logger)
        {
            _context = context;
            _logger = logger;
        }

        public GenericService(UniversityDBContext context)
        {
            this.context = context;
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            // Configurar loggings
            _logger.LogWarning($"{nameof(GenericService<T>)} - {nameof(GetAllAsync)} - Warning Level Log");
            _logger.LogError($"{nameof(GenericService<T>)} - {nameof(GetAllAsync)} - Error Level Log");
            _logger.LogCritical($"{nameof(GenericService<T>)} - {nameof(GetAllAsync)} - Critical Log Level");

            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            // Configurar loggings
            _logger.LogWarning($"{nameof(GenericService<T>)} - {nameof(GetAllAsync)} - Warning Level Log");
            _logger.LogError($"{nameof(GenericService<T>)} - {nameof(GetAllAsync)} - Error Level Log");
            _logger.LogCritical($"{nameof(GenericService<T>)} - {nameof(GetAllAsync)} - Critical Log Level");

            return await _context.Set<T>().FindAsync(id);

        }

        public async Task<T> GetByIdWithSpecAsync(ISpecification<T> spec)
        {
            _logger.LogWarning($"{nameof(GenericService<T>)} - {nameof(GetByIdWithSpecAsync)} - Warning Level Log");
            _logger.LogError($"{nameof(GenericService<T>)} - {nameof(GetByIdWithSpecAsync)} - Error Level Log");
            _logger.LogCritical($"{nameof(GenericService<T>)} - {nameof(GetByIdWithSpecAsync)} - Critical Log Level");
            return await ApplySpecification(spec).FirstOrDefaultAsync();
        }

        public async Task<IReadOnlyList<T>> GetAllIdWithSpecAsync(ISpecification<T> spec)
        {

            _logger.LogWarning($"{nameof(GenericService<T>)} - {nameof(GetAllIdWithSpecAsync)} - Warning Level Log");
            _logger.LogError($"{nameof(GenericService<T>)} - {nameof(GetAllIdWithSpecAsync)} - Error Level Log");
            _logger.LogCritical($"{nameof(GenericService<T>)} - {nameof(GetAllIdWithSpecAsync)} - Critical Log Level");

            return await ApplySpecification(spec).ToListAsync();
        }

        public async Task<int> Add(T entity)
        {
            _logger.LogWarning($"{nameof(GenericService<T>)} - {nameof(Add)} - Warning Level Log");
            _logger.LogError($"{nameof(GenericService<T>)} - {nameof(Add)} - Error Level Log");
            _logger.LogCritical($"{nameof(GenericService<T>)} - {nameof(Add)} - Critical Log Level");

            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _context.Set<T>().Add(entity);
            return await _context.SaveChangesAsync();
             
        }

        public async Task<int> Update(T entity)
        {

            _logger.LogWarning($"{nameof(GenericService<T>)} - {nameof(Update)} - Warning Level Log");
            _logger.LogError($"{nameof(GenericService<T>)} - {nameof(Update)} - Error Level Log");
            _logger.LogCritical($"{nameof(GenericService<T>)} - {nameof(Update)} - Critical Log Level");

            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _context.Set<T>().Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;

            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int id)
        {
            _logger.LogWarning($"{nameof(GenericService<T>)} - {nameof(Delete)} - Warning Level Log");
            _logger.LogError($"{nameof(GenericService<T>)} - {nameof(Delete)} - Error Level Log");
            _logger.LogCritical($"{nameof(GenericService<T>)} - {nameof(Delete)} - Critical Log Level");

            T entity = await _context.Set<T>().FindAsync(id);

            _context.Set<T>().Remove(entity);

            return await _context.SaveChangesAsync();
        }

        private IQueryable<T> ApplySpecification(ISpecification<T> spec)
        {
            return SpecificationEvaluator<T>.GetQuery(_context.Set<T>().AsQueryable(), spec);
        }

        public bool EntityExist(T entity, int id)
        {
            return (_context.Set<T>().Any(entity => entity.Id == id));
        }


    }
}
