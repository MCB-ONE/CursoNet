using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace UniversityApiBE.Dtos.Categories
{
    public class CategoryDto: BaseEntity
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        // Relación Many to Many con courses
    }
}
