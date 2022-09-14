using Core.Entities;

namespace UniversityApiBE.Dtos.Students
{
    public class StudentUpdateDto: BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime Birthay { get; set; }

        // Relación many to many con Students
        public List<int>? CoursesId { get; set; }
        // Relación one to one con user
    }
}
