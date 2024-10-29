using AutoMapper;
using OnlineEdu.Entity.Entities;
using OnlineEdu.WebUI.DTOs.RoleDtos;
using OnlineEdu.WebUI.DTOs.TeacherSocialDtos;
using OnlineEdu.WebUI.DTOs.UserDtos;

namespace OnlineEdu.WebUI.Mappings
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<AppRole, ResultRoleDto>().ReverseMap();
            CreateMap<AppRole, CreateRoleDto>().ReverseMap();
            CreateMap<AppRole, UpdateRoleDto>().ReverseMap();
            CreateMap<AppUser, ResultUserDto>().ReverseMap();
            CreateMap<TeacherSocial, ResultTeacherSocialDto>().ReverseMap();
        }
    }
}
