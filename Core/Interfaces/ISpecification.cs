using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Core.Interfaces
{
    public interface ISpecification<T> 
    {
        // Representa la lógica que queremos aplicar a una entidad
        Expression<Func<T, bool>> Criteria { get; } 

        // Representa las relaciones que vamos a poder implementar sobre una entidad
        List<Expression<Func<T, object>>> Includes  { get; }

        //Func<IQueryable<T>, IIncludableQueryable<T, object>> Include { get; }
    }
}
