using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class NewsFeed
    {
        public NewsFeed()
        {
            NewsItems = new HashSet<NewsItem>();
        }

        public int Id { get; set; }
        public string FeedName { get; set; } = null!;
        public string FeedUrl { get; set; } = null!;
        public string ImageDefault { get; set; } = null!;
        public bool IsConcrete { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<NewsItem> NewsItems { get; set; }
    }
}
