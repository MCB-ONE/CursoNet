
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

        // Devuelve un int porque la bd lo que devuelve en realidad es la cantidad de records o transacciones que se han realizado de manera exitosa -> en caso de fallar devuelve un 0
        Task<int> Add(T entity);    

        Task<int> Update(T entity);

        Task<int> Delete(int id);

        bool EntityExist(T entity, int id);


        // TODO Crear método generico que compruebe si existe la tabla

        //if (_userRepository.Users == null)
        //  {
        //      return NotFound();
        //}
    }
}
