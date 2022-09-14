using AutoMapper;
using Core.Entities;

namespace UniversityApiBE.Dtos.Categories
{
    public class CategoryProfiles: Profile
    {
        public CategoryProfiles()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
        }

    }
}
