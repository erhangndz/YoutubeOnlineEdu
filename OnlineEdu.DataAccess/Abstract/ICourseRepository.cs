using OnlineEdu.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.DataAccess.Abstract
{
    public interface ICourseRepository: IRepository<Course>
    {
        List<Course> GetAllCoursesWithCategories();
        void ShowOnHome(int id);
        void DontShowOnHome(int id);


    }
}
