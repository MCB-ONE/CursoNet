using System.ComponentModel.DataAnnotations;

namespace UniversityApiBE.Models.DataModels
{
    public class BaseEntity
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string UpdatedBy { get; set; } = String.Empty;
        public DateTime? UpdatedAt { get; set; }
        public string DeletedBy { get; set; } = String.Empty;
        public DateTime? DeletedAt { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
