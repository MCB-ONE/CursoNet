using AutoMapper;
using Core.Entities;

namespace UniversityApiBE.Dtos.Indexes
{
    public class IndexesProfile : Profile
    {

        public IndexesProfile()
        {
            CreateMap<Core.Entities.Index, IndexDto>().ReverseMap();
            CreateMap<Core.Entities.Index, IndexCreateDto>().ReverseMap();


        }
    }
}
