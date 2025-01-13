using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.Entity.Entities
{
    public class AppUser: IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? ImageUrl { get; set; }

        public virtual List<Course> Courses { get; set; }
        public virtual List<CourseRegister> CourseRegisters { get; set; }

        public virtual List<Blog> Blogs { get; set; }
        public virtual List<TeacherSocial> TeacherSocials { get; set; }

    }
}
