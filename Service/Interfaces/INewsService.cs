using Core.Entities;
using Service.DTOs;
using System.Linq.Expressions;

namespace Service.Interfaces
{
    public interface INewsService
    {
        Task<IEnumerable<NewsItemDTO>> GetAllAsync();
        Task<IEnumerable<NewsItemDTO>> GetManyAsync(Expression<Func<NewsItem, bool>> query);
        Task<IEnumerable<NewsFeedDTO>> GetAllFeedsAsync();
    }
}
