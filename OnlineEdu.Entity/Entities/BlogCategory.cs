using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.Entity.Entities
{
    public class BlogCategory
    {
        public int BlogCategoryId { get; set; }
        public string Name { get; set; }

        public List<Blog> Blogs { get; set; }

    }
}
