using AutoMapper;
using Core.Entities;
using UniversityApiBE.Dtos.Courses;

namespace UniversityApiBE.Dtos.Students
{
    public class StudentProfiles: Profile
    {
        public StudentProfiles()
        {
            CreateMap<Student, StudentDto>().ReverseMap();
            CreateMap<StudentCreateDto, Student>().ReverseMap();  
            CreateMap<StudentUpdateDto, StudentDto>();
            CreateMap<Student, StudentUpdateDto>().ReverseMap();
            CreateMap<Course, StudentCourseDto>();
                
        }

    }
}
