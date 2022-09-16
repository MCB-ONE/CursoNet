namespace UniversityApiBE.Services.Indexes
{
    public interface IIndexesService
    {
        Task<Core.Entities.Index> FilterIndexByCourseAsync(int courseId);
    }
}
