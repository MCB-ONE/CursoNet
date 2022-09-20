using Microsoft.EntityFrameworkCore;
using Core.Entities;
using Core.Interfaces;

namespace Core.Specifications
{
    public class SpecificationEvaluator<T> where T: BaseEntity
    {
        // Método encargado de agregar las relaciones necesarias y los filtros (condiciones lógicas) en cada consulta
        public static IQueryable<T> GetQuery(IQueryable<T> inputQuery, ISpecification<T> spec)
        {
            if(spec.Criteria != null)
            {
                inputQuery = inputQuery.Where(spec.Criteria);
            }

            inputQuery = spec.Includes.Aggregate(inputQuery, (current, include) => current.Include(include));

            return inputQuery;
        }

    }
}
