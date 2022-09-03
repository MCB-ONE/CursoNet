using UniversityApiBE.Dtos.StudentDto;

namespace UniversityApiBE.Dtos.UserDto
{
    public class StudentUserDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime Birthay { get; set; }

        // Relación many to many con Students
        public ICollection<StudentCourseDto>? Courses { get; set; } = new List<StudentCourseDto>();
    }
}
