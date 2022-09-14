namespace UniversityApiBE.Dtos.Students
{
    public class StudentCreateDto
    {
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime Birthay { get; set; }
        public string CreatedBy { get; set; }
        // Relación one to one con user
        public int UserId { get; set; }

    }
}
