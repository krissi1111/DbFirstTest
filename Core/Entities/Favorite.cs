using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class Favorite
    {
        public int UserId { get; set; }
        public int NewsItemId { get; set; }
        public int Id { get; set; }
        public bool IsDeleted { get; set; }

        public virtual NewsItem NewsItem { get; set; } = null!;
        public virtual AspNetUser User { get; set; } = null!;
    }
}
