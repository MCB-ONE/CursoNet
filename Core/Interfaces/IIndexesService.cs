namespace Core.Interfaces
{
    public interface IIndexesService: IGenericService<Core.Entities.Index>
    {
        Task<Core.Entities.Index> FilterIndexByCourse(int courseId);
    }
}
