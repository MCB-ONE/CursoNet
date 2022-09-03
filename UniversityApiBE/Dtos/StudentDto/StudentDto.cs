using Core.Entities;

namespace UniversityApiBE.Dtos.StudentDto
{
    public class StudentDto: BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime Birthay { get; set; }

        // Relación many to many con Students
        public ICollection<StudentCourseDto>? Courses { get; set; } = new List<StudentCourseDto>();

        // Relación one to one con user
        public StudentUserDto User { get; set; }

    }
}
