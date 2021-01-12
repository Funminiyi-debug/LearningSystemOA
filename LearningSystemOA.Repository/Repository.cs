using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using LearningSystemOA.Repository.Data;

namespace LearningSystemOA.Repository
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        private readonly RepositoryContext _repo;

        public Repository(RepositoryContext repo)
        {
            _repo = repo;
        }
        public IEnumerable<T> GetAll()
        {
            return _repo.Set<T>().ToList();
        }

        public IQueryable<T> GetByCondition(Expression<Func<T, bool>> expression)
        {
            return _repo.Set<T>().Where(expression);
        }

        public T GetOne(int id)
        {
            return _repo.Set<T>().Find(id);
        }

        public void Insert(T entity)
        {
            _repo.Set<T>().Add(entity);
            _repo.SaveChanges();
        }

        public void Update(T entity)
        {
            _repo.Set<T>().Update(entity);
            _repo.SaveChanges();
        }
    }
}
