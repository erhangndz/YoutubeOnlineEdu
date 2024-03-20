using OnlineEdu.Business.Abstract;
using OnlineEdu.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.Business.Concrete
{
    public class GenericManager<T>(IRepository<T> _repository) : IGenericService<T> where T : class
    {
        public int TCount()
        {
          return _repository.Count();
        }

        public void TCreate(T entity)
        {
           _repository.Create(entity);
        }

        public void TDelete(int id)
        {
           _repository.Delete(id);
        }

        public int TFilteredCount(Expression<Func<T, bool>> predicate)
        {
           return _repository.FilteredCount(predicate);
        }

        public T TGetByFilter(Expression<Func<T, bool>> predicate)
        {
            return _repository.GetByFilter(predicate);
        }

        public T TGetById(int id)
        {
            return _repository.GetById(id);
        }

        public List<T> TGetFilteredList(Expression<Func<T, bool>> predicate)
        {
            return _repository.GetFilteredList(predicate);
        }

        public List<T> TGetList()
        {
            return _repository.GetList();
        }

        public void TUpdate(T entity)
        {
            _repository.Update(entity);
        }
    }
}
