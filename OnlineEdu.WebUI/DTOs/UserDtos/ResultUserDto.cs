using OnlineEdu.Entity.Entities;
using OnlineEdu.WebUI.DTOs.TeacherSocialDtos;

namespace OnlineEdu.WebUI.DTOs.UserDtos
{
    public class ResultUserDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? ImageUrl { get; set; }

        public List<ResultTeacherSocialDto> TeacherSocials { get; set; }
    }
}
