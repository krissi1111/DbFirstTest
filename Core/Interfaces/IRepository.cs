using System.Linq.Expressions;

namespace Core.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAllIncludeAsync(params Expression<Func<T, Object>>[] include);
        Task<IEnumerable<T>> GetManyAsync(Expression<Func<T, bool>> query);
        Task<IEnumerable<T>> GetManyIncludeAsync(Expression<Func<T, bool>> query, params Expression<Func<T, Object>>[] include);
    }
}
