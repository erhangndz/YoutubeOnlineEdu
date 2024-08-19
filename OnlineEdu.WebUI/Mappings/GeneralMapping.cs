using AutoMapper;
using OnlineEdu.Entity.Entities;
using OnlineEdu.WebUI.DTOs.RoleDtos;

namespace OnlineEdu.WebUI.Mappings
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<AppRole, ResultRoleDto>().ReverseMap();
            CreateMap<AppRole, CreateRoleDto>().ReverseMap();
            CreateMap<AppRole, UpdateRoleDto>().ReverseMap();
        }
    }
}
