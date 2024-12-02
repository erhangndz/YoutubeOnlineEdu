using OnlineEdu.Entity.Entities;
using OnlineEdu.WebUI.DTOs.CourseDtos;

namespace OnlineEdu.WebUI.DTOs.CourseRegisterDtos
{
    public class CreateCouseRegisterDto
    {
      

        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        public int CourseId { get; set; }

        public ResultCourseDto Course { get; set; }
    }
}
