using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DomainModels
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? CreationDate { get; set; }
        public string Location { get; set; }
        public int? Age { get; set; }

        //public virtual ICollection<Post> Posts { get; set; }

        public User()
        {
            //Posts = new Collection<Post>();
        }

    }
}
