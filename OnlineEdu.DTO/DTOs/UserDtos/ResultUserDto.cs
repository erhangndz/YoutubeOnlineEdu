using OnlineEdu.DTO.DTOs.TeacherSocialDtos;
using OnlineEdu.Entity.Entities;


namespace OnlineEdu.DTO.DTOs.UserDtos
{
    public class ResultUserDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? ImageUrl { get; set; }

        public List<ResultTeacherSocialDto> TeacherSocials { get; set; }
    }
}
