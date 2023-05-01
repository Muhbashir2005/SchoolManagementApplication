using Microsoft.EntityFrameworkCore;
using SchoolManagementApplication.Repository.Interfaces;
using System.Linq.Expressions;
using SchoolManagementApplication.Context;
using SchoolManagementApplication.Entities;

namespace SchoolManagementApplication.Repository.Implementations
{
	public class  BaseRepository<T> : IRepository<T> where T : BaseEntity, new ()
    {
        protected readonly SchoolDBContext _context;

        protected BaseRepository(SchoolDBContext context)
        {
            _context = context;
        }

        public T Create(T entity)
        {
            _context.Set<T>().Add(entity);
            return entity;
        }

        public T Get(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public T Get(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().SingleOrDefault(expression);
        }

        public bool Exists(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Any(expression);
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public T Update(T entity)
        {
            _context.Set<T>().Update(entity);
            return entity;
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public List<T> GetAll(Expression<Func<T, bool>> expression = null)
        {
            return _context.Set<T>().Where(expression).ToList();
        }

        public List<T> GetAllByIds(List<int> ids)
        {
            return _context.Set<T>().Where(t => ids.Contains(t.Id)).ToList();
        }

        public IReadOnlyList<T> SelectAll()
        {
            return _context.Set<T>().ToList();
        }

        public IReadOnlyList<T> SelectAll(Expression<Func<T, bool>> expression = null)
        {
            return _context.Set<T>().Where(expression).ToList();
        }
	}
}
