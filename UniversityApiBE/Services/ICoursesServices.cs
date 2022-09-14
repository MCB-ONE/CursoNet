using Core.Entities;
using UniversityApiBE.Dtos.Courses;

namespace UniversityApiBE.Services
{
    public interface ICoursesServices
    {
        IEnumerable<Course> AddStudentCourses(IEnumerable<Course> coursesList, Category category);

        //IEnumerable<Course> GetCoursesByCategory(IEnumerable<Course> coursesList, Category category);
        //IEnumerable<Course> GetCoursesWhitNotIndexes(IEnumerable<Course> coursesList);
        //Index GetCourseIndex(Course course, List<Index> indexList);
        //IEnumerable<Student> GetCourseStudents(Course course, IEnumerable<Student> studentsList);

        Task<int> UpdateCourse(CourseUpdateDto courseUpdateDto);


    }
}
