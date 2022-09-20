using Core.Entities;

namespace Core.Interfaces
{
    public interface IStudentsService: IGenericService<Student>
    {
        Task<int> UpdateStudent(int studentId, Student studentUpdated, List<int> newCouresIds);
        Task<List<Student>> FilterStudentsWithOutCourses();
        Task<List<Student>> FilterStudentsByCourses(int courseId);

    }
}
