using AutoMapper;
using Core.Entities;

namespace UniversityApiBE.Dtos.Courses
{
    public class CourseProfiles: Profile
    {
        public CourseProfiles()
        {
            CreateMap<Course, CourseDto>().ReverseMap();

            // Mapear un listado de int (ids) a un listado de categorias
            CreateMap<CourseCreateDto, Course>()
                .ForMember(ent => ent.Categories,
                dto => dto.MapFrom(prop =>
                prop.Categories.Select(id => new Category() { Id = id })));

            CreateMap<CourseUpdateDto, Course>();
            CreateMap<Category, CourseCategoryDto>().ReverseMap();
            CreateMap<Core.Entities.Index, CourseIndexDto>().ReverseMap();
            CreateMap<Student, CourseStudentDto>();
        }
    }
}
