using OnlineEdu.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.DataAccess.Abstract
{
    public interface IBlogRepository: IRepository<Blog>
    {
        List<Blog> GetBlogsWithCategories();

    }
}
