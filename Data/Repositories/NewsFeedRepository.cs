using Core.Entities;
using Core.Interfaces;

namespace Data.EF.Repositories
{
    public class NewsFeedRepository : Repository<NewsFeed>, INewsFeedRepository
    {
        public NewsFeedRepository(NewsAppDbContextContext context) : base(context)
        {

        }
    }
}
