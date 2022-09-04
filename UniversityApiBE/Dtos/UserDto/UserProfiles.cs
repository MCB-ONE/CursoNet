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
            CreateMap<Student, StudentUserDto>();
            CreateMap<User, UserCreateDto>().ReverseMap();
            CreateMap<UserDto, UserCreateDto>().ReverseMap();
            CreateMap<UserUpdateDto, User>().ReverseMap();
            CreateMap<UserUpdateDto, UserDto>().ReverseMap();
        }

    }
}
