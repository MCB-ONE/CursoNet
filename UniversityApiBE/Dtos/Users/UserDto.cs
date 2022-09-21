using Core.Entities;
using UniversityApiBE.Dtos.Students;

namespace UniversityApiBE.Dtos.Users

{
    public class UserDto : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public Roles Rol { get; set; }
        public int? StudentId { get; set; }
        public virtual StudentDto? Student { get; set; }
    }
}
