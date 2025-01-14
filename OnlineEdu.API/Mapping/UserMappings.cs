using AutoMapper;
using OnlineEdu.DTO.DTOs.UserDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Mapping
{
    public class UserMappings: Profile
    {
        public UserMappings()
        {
            CreateMap<AppUser, RegisterDto>().ReverseMap();
        }
    }
}
