using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class Index: BaseEntity
    {
        [Required]
        public string List { get; set; } = string.Empty;
        [Required]
        public virtual Course Course { get; set; }
    }
}
