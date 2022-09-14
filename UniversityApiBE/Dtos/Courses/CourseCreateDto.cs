using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace UniversityApiBE.Dtos.Courses
{
    public class CourseCreateDto: BaseEntity
    {
        public string? Name { get; set; }
        public string? ShortDescription { get; set; }
        public string? LongDescription { get; set; }
        public Levels Level { get; set; }

        //TODO: Aañadir relacion CATEGORIAS
        public List<int> Categories { get; set; }

        public int? Index { get; set; }

        //TODO: Añadir relacion students. Necesatrio?
        //public ICollection<CourseStudentDto>? Students { get; set; }

    }
}
