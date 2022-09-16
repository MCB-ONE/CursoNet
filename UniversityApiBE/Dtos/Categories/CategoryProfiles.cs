using AutoMapper;
using Core.Entities;
using UniversityApiBE.Dtos.Courses;

namespace UniversityApiBE.Dtos.Categories
{
    public class CategoryProfiles: Profile
    {
        public CategoryProfiles()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Course, CourseDto>().ReverseMap();
        }

    }
}
