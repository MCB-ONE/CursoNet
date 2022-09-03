using Core.Entities;
namespace UniversityApiBE.Services
{
    public class Services
    {

        public static IEnumerable<User> FindUserByEmail(IEnumerable<User> uersList, string email)
        {
            var emailFormatted = email.ToLower().Replace(" ", String.Empty);
            var matchUser = from user in uersList
                            where user.Email.ToLower().Replace(" ", String.Empty) == emailFormatted
                            select user;

            return matchUser;
        }

        public static IEnumerable<Student> FindAdultStudent(IEnumerable<Student> studentList)
        {
            var adultsStudents = from student in studentList
                            where DateTime.Today.AddTicks(-student.Birthay.Ticks).Year - 1 > 18
                            select student;

            return adultsStudents;
        }

        public static IEnumerable<Student> FindStudentsWhitCourses (IEnumerable<Student> studentList)
        {
            var studentsWhitCourses = from student in studentList
                                      where student.Courses.Count > 0
                                      select student;
            return studentsWhitCourses;
        }

        public static IEnumerable<Course> FindCoursesByLevelWhitEnrolledStudents(IEnumerable<Course> coursesList, Levels level)
        {
            var matchCourses = from course in coursesList
                               where course.Level == level && course.Students.Count > 0
                               select course;
            return matchCourses;          

        }
        public static IEnumerable<Course> FindCoursesByLevelAndCategory(IEnumerable<Course> coursesList, Levels level, Category category)
        {

            var matchCourses = from courses in coursesList
                               from cat in courses.Categories
                               where (courses.Level == level && cat.Id == category.Id)
                               select courses;

            return matchCourses;

        }

        public static IEnumerable<Course> FindEmptyCourses(IEnumerable<Course> coursesList)
        {
            var matchCourses = coursesList.Where(course => course.Students.Count == 0);

            return matchCourses;

        }






    }
}
