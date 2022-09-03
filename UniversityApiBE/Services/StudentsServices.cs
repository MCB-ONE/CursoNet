using Core.Entities;

namespace UniversityApiBE.Services
{
    public class StudentsServices : IStudentsService
    {
        public IEnumerable<Course> GetStudentCourses(Student student, IEnumerable<Course> coursesList)
        {
            var studentCoursesList = from studentCourse in student.Courses
                                     from course in coursesList
                                     where course.Id == studentCourse.Id
                                     select course;
            return studentCoursesList;
        }

        public IEnumerable<Student> GetStudentsWhitCourses(IEnumerable<Student> studentList)
        {
            var studentsWhitCourses = from student in studentList
                                      where student.Courses.Count > 0
                                      select student;
            return studentsWhitCourses;
        }

        public IEnumerable<Student> GetStudentsWhitNotCourses(IEnumerable<Student> studentList)
        {
            var studentsWhitCourses = from student in studentList
                                      where student.Courses.Count == 0
                                      select student;
            return studentsWhitCourses;
        }
    }
}
