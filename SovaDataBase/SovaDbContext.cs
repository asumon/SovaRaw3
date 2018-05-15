using DomainModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SovaDataBase
{
    public class SovaDbContext : DbContext
    {
        //public SovaDbContext(DbContextOptions<SovaDbContext> options)
        //    : base(options)
        //{

            

        //}


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseMySql(
                "server=127.0.0.1;port=3306;database=raw3;uid=root;password=mysql;");
        }

        public DbSet<Posttype> PostType { get; set; }

        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Tag> Tag { get; set; }
        public DbSet<History> History { get; set; }

       public DbSet<KeySearch> KeySearch { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Posttype>().ToTable("posttype");
            modelBuilder.Entity<Posttype>().Property(x => x.Id).HasColumnName("posttypeid");
            modelBuilder.Entity<Posttype>().Property(x => x.Name).HasColumnName("posttype");

            modelBuilder.Entity<History>().ToTable("history");
           
            


            modelBuilder.Entity<Post>().ToTable("posts");
            modelBuilder.Entity<Post>().Property(x => x.CloseDate).HasColumnName("closedate");
            modelBuilder.Entity<Post>().Property(x => x.Id).HasColumnName("postid");
            modelBuilder.Entity<Post>().Property(x => x.ParentId).HasColumnName("parentid");
            modelBuilder.Entity<Post>().Property(x => x.AcceptedanswerId).HasColumnName("acceptedanswerid");
            modelBuilder.Entity<Post>().Property(x => x.PosttypeId).HasColumnName("post_type_id");
            modelBuilder.Entity<Post>().Property(x => x.UserId).HasColumnName("user_id");
            //modelBuilder.Entity<Post>().HasOne(u => u.User).WithMany(p => p.Posts).HasForeignKey(u => u.UserId);

            modelBuilder.Entity<User>().ToTable("users");
            modelBuilder.Entity<User>().Property(x => x.Id).HasColumnName("userid");
            modelBuilder.Entity<User>().Property(x => x.Location).HasColumnName("userlocation");
            modelBuilder.Entity<User>().Property(x => x.Name).HasColumnName("username");


            modelBuilder.Entity<Comments>().ToTable("comments");
            modelBuilder.Entity<Comments>().Property(x => x.Id).HasColumnName("commentid");
            //modelBuilder.Entity<Comments>().Property(x => x.PostId).HasColumnName("postid");
            modelBuilder.Entity<Comments>().Property(x => x.Commentscore).HasColumnName("commentscore");
            modelBuilder.Entity<Comments>().Property(x => x.UserId).HasColumnName("userid");
            modelBuilder.Entity<Comments>().Property(x => x.CommentDate).HasColumnName("commentcreatedate");


            // modelBuilder.Entity<Tag>().ToTable("tags");
            // modelBuilder.Entity<PostTag>().ToTable("posts_tags");
            // modelBuilder.Entity<PostTag>().HasKey(x => new { x.post_id, x.tag_id });

            //modelBuilder.Entity<PostTag>()
            //.HasKey(bc => new { bc.post_id, bc.tag_id });



            // SearchResults

            modelBuilder.Entity<KeySearch>().Property(x => x.Id).HasColumnName("id");
            modelBuilder.Entity<KeySearch>().Property(x => x.Title).HasColumnName("title");
            modelBuilder.Entity<KeySearch>().Property(x => x.Rank).HasColumnName("rank");





        }
    }

    
}
