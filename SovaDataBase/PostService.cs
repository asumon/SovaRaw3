using DomainModels;
using Logics;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SovaDataBase
{
    //implementation for IPostService
    public class PostService : IPostService
    {
         

        public PostService()
        {
            
        }

        public IQueryable<Post> GetAllPost()
        {
            var context = new SovaDbContext();
            var posts = context.Posts.Where(x => x.PosttypeId == 1).Include(x => x.User);

            return posts;
        }


        public int TotalPosts()
        {
            using (var db = new SovaDbContext())
            {
                return db.Posts.Count();
            }
        }

        public IQueryable<Post> GetAllPost(Paging PageInfo)
        {
            var context = new SovaDbContext();
            var posts = context.Posts.Where(x => x.PosttypeId == 1).Include(x => x.User)
                .Skip(PageInfo.Page * PageInfo.PageSize)
                    .Take(PageInfo.PageSize);

            return posts;
        }

        public IEnumerable<Post> GetAllPostForUser(int userid)
        {
            var context = new SovaDbContext();
            var postForUsers = context.Posts.Where(x => x.UserId == userid);
            return postForUsers;
        }

        public IQueryable<Post> GetAllAnswerForPost(int postid)
        {
            var context = new SovaDbContext();
            var answersForPost = context.Posts.Where(x => x.PosttypeId == 2 && x.ParentId == postid)
               
                .Include(x=>x.Comments);
            return answersForPost;
        }

        public IEnumerable<Post> GetPostById(int id)
        {
            var context = new SovaDbContext();
            var post = context.Posts.Where(x =>x.Id == id).Include(x => x.User)
                .Include(x=>x.Comments).ThenInclude(u=> u.Users);
            return post;
        }


    }
}
