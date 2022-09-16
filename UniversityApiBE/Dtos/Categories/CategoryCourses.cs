using UniversityApiBE.Dtos.Courses;

namespace UniversityApiBE.Dtos.Categories
{
    public class CategoryCourses
    {
        public string Name { get; set; } = string.Empty;

        public List<CourseDto> CategorieCourses { get; set; }
    }
}
