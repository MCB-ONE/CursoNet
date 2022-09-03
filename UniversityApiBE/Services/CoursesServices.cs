using Core.Entities;
using Index = Core.Entities.Index;

namespace UniversityApiBE.Services
{
    public class CoursesServices : ICoursesServices
    {
        public IEnumerable<Course> GetCoursesByCategory(IEnumerable<Course> coursesList, Category category)
        {
            var coursesByCategory = from courses in coursesList
                                    from cat in courses.Categories
                                    where (cat.Id == category.Id)
                                    select courses;

            return coursesByCategory;
        }

        public Index GetCourseIndex(Course course, List<Index> indexList)
        {
            var indexMatch = from index in indexList
                               where index.Id == course.IdIndex
                               select index;
            
            return (Index)indexMatch;
        }

        public IEnumerable<Course> GetCoursesWhitNotIndexes(IEnumerable<Course> coursesList)
        {
            var coursesMatch = coursesList.Where(course => course.IdIndex == null);
            return coursesMatch;
        }

        public IEnumerable<Student> GetCourseStudents(Course course, IEnumerable<Student> studentsList)
        {
            var studentsMatch = from student in studentsList
                                from cStudent in course.Students
                                where cStudent.Id == student.Id
                                select student;

            return studentsMatch;

        }

    }
}
