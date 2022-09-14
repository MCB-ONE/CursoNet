using AutoMapper;
using Core.Entities;

namespace UniversityApiBE.Dtos.Users
{
    public class UserProfiles : Profile
    {
        public UserProfiles()
        {
            // ReverseMap() => Invierte el mapeo 
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User, UserCreateDto>().ReverseMap();
            CreateMap<UserDto, UserCreateDto>().ReverseMap();
            CreateMap<UserUpdateDto, User>().ReverseMap();
            CreateMap<UserUpdateDto, UserDto>().ReverseMap();
        }

    }
}
