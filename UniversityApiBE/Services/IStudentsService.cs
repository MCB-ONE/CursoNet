using Core.Entities;
using UniversityApiBE.Dtos.Courses;

namespace UniversityApiBE.Services
{
    public interface IStudentsService
    {
        IEnumerable<Student> GetStudentsWhitCourses(IEnumerable<Student> studentList);
        IEnumerable<Student> GetStudentsWhitNotCourses(IEnumerable<Student> studentList);
        IEnumerable<Course> GetStudentCourses(Student student, IEnumerable<Course> coursesList);

    }
}
