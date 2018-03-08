using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app1.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public DateTime? CreateDate { get; set; }
        public DateTime? LastUpdate { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }

}
