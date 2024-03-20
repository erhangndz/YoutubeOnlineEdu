using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.DataAccess.Abstract
{
    public interface IRepository<T> where T : class
    {
        List<T> GetList();

        T GetByFilter(Expression<Func<T, bool>> predicate);

        T GetById(int id);

        void Create(T entity);

        void Update(T entity);

        void Delete(int id);

        int Count();

        int FilteredCount(Expression<Func<T, bool>> predicate);

        List<T> GetFilteredList(Expression<Func<T,bool>> predicate);
    }
}
