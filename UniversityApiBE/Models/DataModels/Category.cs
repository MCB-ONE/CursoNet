using System.ComponentModel.DataAnnotations;

namespace UniversityApiBE.Models.DataModels
{
    public class Category: BaseEntity
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        // Relación Many to Many con courses
        public ICollection<Course>? Courses { get; set; } = new List<Course>();
    }
}
