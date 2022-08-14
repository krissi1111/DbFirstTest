using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Data.EF.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        readonly NewsAppDbContextContext context;

        public Repository(NewsAppDbContextContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await context.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAllIncludeAsync(params Expression<Func<T, object>>[] include)
        {
            var set = context.Set<T>().AsQueryable().Take(50);
            foreach (var item in include)
            {
                set = set.Include(item);
            }
            return await set.ToListAsync();
        }

        public async Task<IEnumerable<T>> GetManyAsync(Expression<Func<T, bool>> query)
        {
            return await context.Set<T>().Where(query).ToListAsync();
        }

        public async Task<IEnumerable<T>> GetManyIncludeAsync(Expression<Func<T, bool>> query, params Expression<Func<T, object>>[] include)
        {
            var set = context.Set<T>().Where(query).AsQueryable();
            foreach (var item in include)
            {
                set = set.Include(item);
            }
            return await set.ToListAsync();
        }
    }
}
