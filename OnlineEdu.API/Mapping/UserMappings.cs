using AutoMapper;
using OnlineEdu.DTO.DTOs.RoleDtos;
using OnlineEdu.DTO.DTOs.UserDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Mapping
{
    public class UserMappings: Profile
    {
        public UserMappings()
        {
            CreateMap<AppUser, RegisterDto>().ReverseMap();
        
            CreateMap<AppRole, CreateRoleDto>().ReverseMap();
            CreateMap<AppRole, UpdateRoleDto>().ReverseMap();
            CreateMap<AppUser, ResultUserDto>().ReverseMap();
          
        }
    }
}
