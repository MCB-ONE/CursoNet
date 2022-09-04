using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    public class Index: BaseEntity
    {
        [Required]
        public string List { get; set; } = string.Empty;
        [Required]
        public virtual Course Course { get; set; }

        // Relación one to one con Indexes
        [ForeignKey("Course")]
        public int? IdIndex { get; set; }
    }
}
