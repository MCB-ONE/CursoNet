using BussinesLogic.Data;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace UniversityApiBE.Services.Categories
{
    public class CategoriesService : ICategoriesService
    {

        private readonly UniversityDBContext _context;

        public CategoriesService(UniversityDBContext context)
        {
            _context = context;
        }

        public async Task<Category> GetCoursesByCategory(int categoryId)
        {
            var categoryMatch =  await _context.Categories
                                .Include(c => c.Courses)
                                .FirstOrDefaultAsync(c => c.Id == categoryId);

            
            return categoryMatch;
        }
    }
}
