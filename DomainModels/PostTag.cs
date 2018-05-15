using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels
{
    public class PostTag
    {
        public int post_id { get; set; }
        //public ICollection<Post> Post { get; set; }

        public int tag_id { get; set; }
        public ICollection<Tag> Tag { get; set; }


    }
}
