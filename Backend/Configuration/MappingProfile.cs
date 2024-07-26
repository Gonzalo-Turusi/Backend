using AutoMapper;
using Entities.DTO;
using Entities.Models;

namespace Backend.Configuration
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Table1, Table1DTO>();
            CreateMap<Table1DTO, Table1>();
            CreateMap<Table2, Table2DTO>();
            CreateMap<Table2DTO, Table2>();
        }
    }
}
