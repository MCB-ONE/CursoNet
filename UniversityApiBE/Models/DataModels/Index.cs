using System.ComponentModel.DataAnnotations;

namespace UniversityApiBE.Models.DataModels
{
    public class Index: BaseEntity
    {
        [Required]
        public string List { get; set; } = string.Empty;
        [Required]
        public virtual Course Course { get; set; }
    }
}
