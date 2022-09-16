using Core.Entities;
using UniversityApiBE.Dtos.Courses;

namespace UniversityApiBE.Services.Courses
{
    public interface ICoursesServices
    {
        Task<List<Course>> FilterCoursesByCategoryAsync(int categoryId);
        Task<List<Course>> FilterCoursesWhitoutIndexAsync();

        //IEnumerable<Course> GetCoursesWhitNotIndexes(IEnumerable<Course> coursesList);
        //Index GetCourseIndex(Course course, List<Index> indexList);
        //IEnumerable<Student> GetCourseStudents(Course course, IEnumerable<Student> studentsList);

    }
}
