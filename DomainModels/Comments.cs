using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels
{
    public class Comments
    {
        public int Id { get; set; }
        public int Commentscore { get; set; }
        public string CommentText { get; set; }
        public DateTime CommentDate { get; set; }


       

        public User Users { get; set; }
        public int UserId { get; set; }

       

    }
}
