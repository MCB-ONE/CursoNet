using Core.Entities;

namespace UniversityApiBE.Dtos.UserDto

{
    public class UserDto : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public int? StudentId { get; set; }
        public virtual StudentUserDto? Student { get; set; }
    }
}
