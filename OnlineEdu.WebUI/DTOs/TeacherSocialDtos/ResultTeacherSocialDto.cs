using OnlineEdu.WebUI.DTOs.UserDtos;

namespace OnlineEdu.WebUI.DTOs.TeacherSocialDtos
{
    public class ResultTeacherSocialDto
    {
        public int TeacherSocialId { get; set; }
        public string Url { get; set; }
        public string SocialMediaName { get; set; }
        public string Icon { get; set; }
        public int TeacherId { get; set; }
        public ResultUserDto Teacher { get; set; }
    }
}
