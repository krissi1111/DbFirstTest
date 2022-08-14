using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public partial class Comment
    {
        public Comment()
        {
            InverseParent = new HashSet<Comment>();
        }

        public int Id { get; set; }
        public int NewsItemId { get; set; }
        public int UserId { get; set; }
        public string Text { get; set; } = null!;
        public DateTime Date { get; set; }
        public bool TopLevelComment { get; set; }
        public int? ParentId { get; set; }

        public virtual NewsItem NewsItem { get; set; } = null!;
        public virtual Comment? Parent { get; set; }
        public virtual AspNetUser User { get; set; } = null!;
        public virtual ICollection<Comment> InverseParent { get; set; }
    }
}
