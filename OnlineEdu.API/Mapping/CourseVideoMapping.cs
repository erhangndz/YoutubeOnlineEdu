using AutoMapper;
using OnlineEdu.DTO.DTOs.CourseVideoDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Mapping
{
    public class CourseVideoMapping: Profile
    {
        public CourseVideoMapping()
        {
            CreateMap<CourseVideo, CreateCourseVideoDto>().ReverseMap();
            CreateMap<CourseVideo, UpdateCourseVideoDto>().ReverseMap();
            CreateMap<CourseVideo, ResultCourseVideoDto>().ReverseMap();
        }
    }
}
