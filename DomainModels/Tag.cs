using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels
{
    public class Tag
    {
        public int Id { get; set; }
        public string tag { get; set; }

        public ICollection<PostTag> PostTag { get; set; }

    }
}
