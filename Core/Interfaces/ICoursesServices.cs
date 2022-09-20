using Core.Entities;
namespace Core.Interfaces
{
    public interface ICoursesServices: IGenericService<Course>
    {
        Task<List<Course>> FilterCoursesByCategory(int categoryId);
        Task<List<Course>> FilterCoursesWhitoutIndex();
        Task<int> UpdateCourse(int courseId, Course courseUpdated ,List<int> newCategoriesIds);

        Task<int> CreateCourseWhitCategories(Course newCourse);

    }
}
