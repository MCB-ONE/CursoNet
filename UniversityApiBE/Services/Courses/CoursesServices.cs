
using BussinesLogic.Data;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using UniversityApiBE.Dtos.Courses;
using UniversityApiBE.Services.Courses;

namespace UniversityApiBE.Services.Courses
{
    public class CoursesServices : ICoursesServices
    {
        private readonly UniversityDBContext _context;

        public CoursesServices(UniversityDBContext context)
        {
            _context = context;
        }

        public async Task<List<Course>> FilterCoursesByCategoryAsync(int categoryId)
        {
            var categoryExist = await _context.Categories.AnyAsync(c => c.Id == categoryId);

            if (!categoryExist)
                return null;


            var courses = await _context.Courses
                                .Include(c => c.Categories)
                                .Where(c => c.Categories.Any(x => x.Id ==   categoryId)).ToListAsync();

            return courses;
        }

        public async Task<List<Course>> FilterCoursesWhitoutIndexAsync()
        {
            return await _context.Courses
             .Where(c => c.Index == null)
             .Include(c => c.Categories).
             ToListAsync();


        }

    }
}
