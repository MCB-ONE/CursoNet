using UniversityApiBE.Dtos.Courses;

namespace UniversityApiBE.Dtos.Users
{
    public class UserStudentDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public ICollection<CourseDto>? Courses { get; set; }


    }
}
