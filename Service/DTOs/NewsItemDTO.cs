namespace Service.DTOs
{
    public class NewsItemDTO
    {
        public int Id { get; set; }
        public int NewsFeedId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Summary { get; set; } = string.Empty;
        public string Link { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public DateTime Date { get; set; }

        public IEnumerable<CommentDTO> Comments { get; set; } = new List<CommentDTO>();
        //public NewsFeedDTO NewsFeed { get; set; }
    }
}
