using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DomainModels
{
    public class Posttype
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Post> posts { get; set; }

        public Posttype()
        {
            posts = new Collection<Post>();
        }

    }
}
