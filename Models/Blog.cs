using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app1.Models
{
    public partial class Blog
    {
        public Blog()
        {
            Post = new HashSet<Post>();
        }

        public int BlogId { get; set; }
        public string Url { get; set; }
        public string BlogName { get; set; }
        public string Owner { get; set; }
        public DateTime? CreateDate { get; set; }

        public virtual ICollection<Post> Post { get; set; }
    }

}
