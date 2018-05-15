using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomainModels
{
    
    public class Post
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public int? AcceptedanswerId { get; set; }
        public DateTime CreationDate { get; set; }
        public string Body { get; set; }
        public DateTime? CloseDate { get; set; }
        public string Title { get; set; }
        public int? LinkPostId { get; set; }
        public int Score { get; set; }


        public int UserId { get; set; }
        public User User { get; set; }

        public Posttype PostType { get; set; }
        public int PosttypeId { get; set; }

        public ICollection<Comments> Comments { get; set; }

       
        public Post()
        {
            Comments = new Collection<Comments>();
            
        }



    }
}
