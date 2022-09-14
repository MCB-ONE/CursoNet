using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace UniversityApiBE.Dtos.Courses
{
    public class CourseDto: BaseEntity
    {
        public string? Name { get; set; }
        public string? ShortDescription { get; set; }
        public string? LongDescription { get; set; }
        public Levels Level { get; set; }
        public List<CourseCategoryDto> Categories { get; set; }

        public CourseIndexDto Index { get; set; }

        //TODO: Añadir relacion students. Necesatrio?
        public List<CourseStudentDto>? Students { get; set; }


    }
}
