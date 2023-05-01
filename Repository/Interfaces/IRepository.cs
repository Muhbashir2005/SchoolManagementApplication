using SchoolManagementApplication.Entities;
using System.Linq.Expressions;

namespace SchoolManagementApplication.Repository.Interfaces
{
    // T must be a sub-class of BaseEntity i.e.must inhert from BaseEntity Class
	public interface IRepository<T> where T : BaseEntity, new()
	{
        T Create(T entity);
        T Get(int id);
        T Update(T entity);
        void Remove(T entity);
        List<T> GetAllByIds(List<int> ids);
        T Get(Expression<Func<T, bool>> expression);
        List<T> GetAll();
        // This "Expression<Func<T, bool>>" not fully understod
        List<T> GetAll(Expression<Func<T, bool>> expression = null);
        bool Exists(Expression<Func<T, bool>> expression);
        IReadOnlyList<T> SelectAll();
        IReadOnlyList<T> SelectAll(Expression<Func<T, bool>> expression = null);
    }
}
