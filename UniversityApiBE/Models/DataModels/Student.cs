using System.ComponentModel.DataAnnotations;

namespace UniversityApiBE.Models.DataModels
{
    public class Student : BaseEntity
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [Required]
        public DateTime Birthay { get; set; }

        // Relación many to many con Students
        public ICollection<Course>? Courses { get; set; } = new List<Course>();

        // Relación one to one con user
        public int UserId { get; set; }

        [Required]
        public virtual User User { get; set; }


    }
}
