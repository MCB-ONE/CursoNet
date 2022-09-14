using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class Category: BaseEntity
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        // Relación Many to Many con courses
        public HashSet<Course>? Courses { get; set; }
    }
}
