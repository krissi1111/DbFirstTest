namespace Service.DTOs
{
    public class NewsFeedDTO
    {
        public string FeedName { get; set; }
        public string FeedUrl { get; set; }

        public List<NewsItemDTO> NewsItems { get; set; }
    }
}
