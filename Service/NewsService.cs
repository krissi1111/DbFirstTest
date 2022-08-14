using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Service.DTOs;
using Service.Interfaces;
using System.Linq.Expressions;

namespace Service
{
    public class NewsService : INewsService
    {
        readonly INewsItemRepository newsItemRepository;
        readonly INewsFeedRepository newsFeedRepository;

        readonly IMapper mapper;

        public NewsService(
            INewsItemRepository newsItemRepository, 
            INewsFeedRepository newsFeedRepository,
            IMapper mapper)
        {
            this.newsItemRepository = newsItemRepository;
            this.newsFeedRepository = newsFeedRepository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<NewsItemDTO>> GetAllAsync()
        {
            var newsItems = await newsItemRepository.GetAllIncludeAsync(n => n.Comments, n => n.NewsFeed);
            
            var news = mapper.Map<List<NewsItemDTO>>(newsItems);
            return news;
        }

        public async Task<IEnumerable<NewsItemDTO>> GetManyAsync(Expression<Func<NewsItem, bool>> query)
        {
            var newsItems = await newsItemRepository.GetManyIncludeAsync(query, item => item.NewsFeed);

            return mapper.Map<List<NewsItemDTO>>(newsItems);
        }

        public async Task<IEnumerable<NewsFeedDTO>> GetAllFeedsAsync()
        {
            var feeds = await newsFeedRepository.GetAllIncludeAsync(feed => feed.NewsItems);

            return mapper.Map<List<NewsFeedDTO>>(feeds);
        }
    }
}
