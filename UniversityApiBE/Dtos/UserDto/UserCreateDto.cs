using Core.Entities;
namespace UniversityApiBE.Dtos.UserDto
{
    public class UserCreateDto
    {

        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string CreatedBy { get; set; } = "Admin";

    }
}
