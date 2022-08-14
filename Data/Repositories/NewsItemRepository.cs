using Core;
using Core.Entities;
using Core.Interfaces;

namespace Data.EF.Repositories
{
    public class NewsItemRepository : Repository<NewsItem>, INewsItemRepository
    {
        public NewsItemRepository(NewsAppDbContextContext context) : base(context)
        {

        }
    }
}
