using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    public class Index: BaseEntity
    {
        [Required]
        public string List { get; set; } = string.Empty;
        [Required]

        // Relación one to one con Course
        [ForeignKey("Course")]
        public int? CourseId { get; set; }
        public Course Course { get; set; }
    }
}
