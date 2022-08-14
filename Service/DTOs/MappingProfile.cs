using AutoMapper;
using Core.Entities;

namespace Service.DTOs
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<NewsItem, NewsItemDTO>();

            CreateMap<Comment, CommentDTO>();

            CreateMap<NewsFeed, NewsFeedDTO>();
        }
    }
}
