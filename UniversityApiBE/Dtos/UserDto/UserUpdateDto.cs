namespace UniversityApiBE.Dtos.UserDto
{
    public class UserUpdateDto
    {
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string UpdatedBy { get; set; } = "Admin";
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
