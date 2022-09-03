using AutoMapper;
using Core.Entities;

namespace UniversityApiBE.Dtos.UserDto
{
    public class UserProfiles : Profile
    {
        public UserProfiles()
        {
            // ReverseMap() => Invierte el mapeo 
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User, UserCreateDto>().ReverseMap();
        }

    }
}
