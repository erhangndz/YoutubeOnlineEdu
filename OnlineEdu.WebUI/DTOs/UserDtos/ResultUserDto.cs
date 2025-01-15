using OnlineEdu.WebUI.DTOs.BlogDtos;
using OnlineEdu.WebUI.DTOs.CourseDtos;
using OnlineEdu.WebUI.DTOs.CourseRegisterDtos;
using OnlineEdu.WebUI.DTOs.TeacherSocialDtos;

namespace OnlineEdu.WebUI.DTOs.UserDtos
{
    public class ResultUserDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string? ImageUrl { get; set; }

        public List<ResultTeacherSocialDto> TeacherSocials { get; set; }

        public List<ResultCourseDto> Courses { get; set; }
        public List<ResultCourseRegisterDto> CourseRegisters { get; set; }

        public List<ResultBlogDto> Blogs { get; set; }
    
    }
}
