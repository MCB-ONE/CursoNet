using Core.Entities;
using UniversityApiBE.Dtos.Courses;
using UniversityApiBE.Dtos.Students;

namespace UniversityApiBE.Services.Students
{
    public interface IStudentsService
    {
        Task<int> UpdateStudentAsync(int studentId, StudentUpdateDto dto);
        Task<List<Student>> FilterStudentsWithOutCoursesAsync();
        Task<List<Student>> FilterStudentsByCoursesAsync(int courseId);
        //IEnumerable<Student> GetStudentsWhitNotCourses(IEnumerable<Student> studentList);
        //IEnumerable<Course> GetStudentCourses(Student student, IEnumerable<Course> coursesList);

    }
}
