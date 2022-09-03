
using Core.Entities;
using Core.Specifications;

namespace Core.Interfaces
{
    /*
       Creamos una interfaz generica para el repositorio
    -> Condicionamos que tipos clases pueden utiliar la interaz con where
       Solo podrá ser implementada por las clases hijas de clase baseEntity
    */
    public interface IGenericRepository<T> where T: BaseEntity
    {
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> GetAllAsync();

        Task<T> GetByIdWithSpecAsync(ISpecification<T> spec);

        Task<IReadOnlyList<T>> GetAllIdWithSpecAsync(ISpecification<T> spec);

        // TODO Crear método generico que compruebe si existe la tabla

        //if (_userRepository.Users == null)
        //  {
        //      return NotFound();
        //}
    }
}
