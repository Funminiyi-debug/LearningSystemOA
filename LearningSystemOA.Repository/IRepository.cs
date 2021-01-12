using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace LearningSystemOA.Repository
{
    public interface IRepository<T>  where T : class
    {
        T GetOne(int id);
        IEnumerable<T> GetAll();
        void Insert(T entity);
        void Update(T entity);
        IQueryable<T> GetByCondition(Expression<Func<T, bool>> expression);
    }
}
