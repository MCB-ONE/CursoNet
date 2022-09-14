using Core.Entities;
using UniversityApiBE.Dtos.Courses;
using UniversityApiBE.Dtos.Users;

namespace UniversityApiBE.Dtos.Students
{
    public class StudentDto: BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime Birthay { get; set; }

        // Relación many to many con Students
        public ICollection<StudentCourseDto>? Courses { get; set; }
        // Relación one to one con user
        public int UserId { get; set; }

    }
}
