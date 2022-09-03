using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    public class Student : BaseEntity
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [Required]
        public DateTime Birthay { get; set; }

        // Relación one to one con users
        [Required]
        [ForeignKey("UserId")]
        public int UserId { get; set; }

        // Relación many to many con Courses
        public ICollection<Course>? Courses { get; set; } = new List<Course>();


    }
}
