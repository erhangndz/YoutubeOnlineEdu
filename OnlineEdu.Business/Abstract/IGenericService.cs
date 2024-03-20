using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.Business.Abstract
{
    public interface IGenericService<T> where T : class
    {
        List<T> TGetList();

        T TGetByFilter(Expression<Func<T, bool>> predicate);

        T TGetById(int id);

        void TCreate(T entity);

        void TUpdate(T entity);

        void TDelete(int id);

        int TCount();

        int TFilteredCount(Expression<Func<T, bool>> predicate);

        List<T> TGetFilteredList(Expression<Func<T, bool>> predicate);
    }
}
