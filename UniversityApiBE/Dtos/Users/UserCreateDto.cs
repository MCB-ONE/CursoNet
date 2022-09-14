using Core.Entities;
namespace UniversityApiBE.Dtos.Users
{
    public class UserCreateDto
    {

        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string CreatedBy { get; set; } = "Admin";

    }
}
