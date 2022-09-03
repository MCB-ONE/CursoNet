using AutoMapper;
using Core.Entities;

namespace UniversityApiBE.Dtos.StudentDto
{
    public class StudentProfiles: Profile
    {
        public StudentProfiles()
        {
                CreateMap<Student, StudentDto>().ReverseMap();
                CreateMap<Course, StudentCourseDto>();
        }

    }
}
