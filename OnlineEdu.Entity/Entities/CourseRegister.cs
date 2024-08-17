using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.Entity.Entities
{
    public class CourseRegister
    {
        public int CourseRegisterId { get; set; }

        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        public int CourseId { get; set; }

        public Course Course { get; set; }
    }
}
