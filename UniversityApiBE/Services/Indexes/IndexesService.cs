using BussinesLogic.Data;
using Microsoft.EntityFrameworkCore;

namespace UniversityApiBE.Services.Indexes
{
    public class IndexesService: IIndexesService
    {
        private readonly UniversityDBContext _context;

        public IndexesService(UniversityDBContext context)
        {
            _context = context;
        }

        public async Task<Core.Entities.Index> FilterIndexByCourseAsync(int courseId)
        {
            var courseExist = await _context.Courses.AnyAsync(c => c.Id == courseId);

            if(!courseExist)
                return null;


            return await _context.Indexes.
                FirstOrDefaultAsync(i => i.CourseId == courseId);

        }
    }
}
