using DomainModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DataAccess
{
    public class PostModel 
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public int AcceptedanswerId { get; set; }
        public DateTime CreationDate { get; set; }
        public string Body { get; set; }
        public DateTime? CloseDate { get; set; }
        public string Title { get; set; }
        public int LinkPostId { get; set; }
        public int Score { get; set; }

        public int UserId { get; set; }
        public UserModel UserModel { get; set; }

        public string UserName { get; set; }



        public Posttype PostType { get; set; }
        public int PosttypeId { get; set; }


        public int CommentId { get; set; }
        public ICollection<Comments> Comments { get; set; }
        


        public PostModel()
        {
            Comments = new Collection<Comments>();
           


        }

    }
}
