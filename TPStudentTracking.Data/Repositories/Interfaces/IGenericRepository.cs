using System.Linq.Expressions;

namespace TPStudentTracking.Data.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        List<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
        IQueryable<T> Where(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetQueryable();
    }
}
