using Core.Entities;

namespace UniversityApiBE.Dtos.Courses
{
    public class CourseUpdateDto : BaseEntity
    { 
        public string? Name { get; set; }
        public string? ShortDescription { get; set; }
        public string? LongDescription { get; set; }
        public Levels Level { get; set; }

        //TODO: Aañadir relacion CATEGORIAS
        public List<int> CategoriesIds { get; set; }

        public CourseIndexDto? Index { get; set; }
    }
}
