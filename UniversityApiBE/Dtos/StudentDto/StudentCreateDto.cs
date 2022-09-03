namespace UniversityApiBE.Dtos.StudentDto
{
    public class StudentCreateDto
    {
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime Birthay { get; set; }
        public int UserId { get; set;}
    }
}
