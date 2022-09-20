using BussinesLogic.Data;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BussinesLogic.Logic
{
    public class IndexesService: GenericService<Core.Entities.Index>, IIndexesService
    {
        private readonly UniversityDBContext _context;

        public IndexesService(UniversityDBContext context): base(context)
        {
            _context = context;
        }

        public async Task<Core.Entities.Index> FilterIndexByCourse(int courseId)
        {
            var courseExist = await _context.Courses.AnyAsync(c => c.Id == courseId);

            if(!courseExist)
                return null;


            return await _context.Indexes.
                FirstOrDefaultAsync(i => i.CourseId == courseId);

        }
    }
}
