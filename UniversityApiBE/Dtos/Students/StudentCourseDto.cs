using Core.Entities;

namespace UniversityApiBE.Dtos.Students
{
    public class StudentCourseDto
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public Levels Level { get; set; }
    }
}
