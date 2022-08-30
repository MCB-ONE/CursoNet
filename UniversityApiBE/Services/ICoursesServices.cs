using UniversityApiBE.Models.DataModels;
using Index = UniversityApiBE.Models.DataModels.Index;

namespace UniversityApiBE.Services
{
    public interface ICoursesServices
    {
        IEnumerable<Course> GetCoursesByCategory(IEnumerable<Course> coursesList, Category category);
        IEnumerable<Course> GetCoursesWhitNotIndexes(IEnumerable<Course> coursesList);
        Index GetCourseIndex(Course course, List<Index> indexList);
        IEnumerable<Student> GetCourseStudents(Course course, IEnumerable<Student> studentsList);


    }
}
