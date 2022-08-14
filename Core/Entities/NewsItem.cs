using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class NewsItem
    {
        public NewsItem()
        {
            Comments = new HashSet<Comment>();
            Favorites = new HashSet<Favorite>();
        }

        public int Id { get; set; }
        public int NewsFeedId { get; set; }
        public string Title { get; set; } = null!;
        public string Summary { get; set; } = null!;
        public string Link { get; set; } = null!;
        public string Image { get; set; } = null!;
        public DateTime Date { get; set; }
        public bool IsDeleted { get; set; }

        public virtual NewsFeed NewsFeed { get; set; } = null!;
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Favorite> Favorites { get; set; }
    }
}
