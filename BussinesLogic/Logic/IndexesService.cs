using BussinesLogic.Data;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BussinesLogic.Logic
{
    public class IndexesService: GenericService<Core.Entities.Index>, IIndexesService
    {
        private readonly UniversityDBContext _context;
        private readonly ILogger<IndexesService> _logger;
        public IndexesService(UniversityDBContext context, ILogger<IndexesService> logger) : base(context, logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<Core.Entities.Index> FilterIndexByCourse(int courseId)
        {
            // Configurar loggings
            _logger.LogWarning($"{nameof(IndexesService)} - {nameof(FilterIndexByCourse)} - Warning Level Log");
            _logger.LogError($"{nameof(IndexesService)} - {nameof(FilterIndexByCourse)} - Error Level Log");
            _logger.LogCritical($"{nameof(IndexesService)} - {nameof(FilterIndexByCourse)} - Critical Log Level");


            var courseExist = await _context.Courses.AnyAsync(c => c.Id == courseId);

            if(!courseExist)
                return null;


            return await _context.Indexes.
                FirstOrDefaultAsync(i => i.CourseId == courseId);

        }
    }
}
