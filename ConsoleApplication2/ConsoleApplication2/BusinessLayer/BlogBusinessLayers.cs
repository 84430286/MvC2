using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication5.Models;
using ConsoleApplication2.DataAccessLayer;
using System.Data.Entity;

namespace ConsoleApplication2.BlogBusinessLayer
{
   public class BlogBusinessLayers
    {
        public void Add(Blog blog)
        {
            using (var db=new BloggingContext())
            {
                db.Blogs.Add(blog);
                db.SaveChanges();
            }
        }
        public List<Blog> Query()
        {
            using (var db = new BloggingContext())
            {
                return db.Blogs.ToList();

            }
                
        }
        public void Update(Blog blog)
        {
            using (var db = new BloggingContext())
            {
                db.Entry(blog).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        //查找包含给定名称name的所有博客
        public List<Blog> Query(string name)
        {
            using (var db = new BloggingContext())
            {
                // 查询所有包含字符串name的博客
                var blogs = from b in db.Blogs
                            where b.Name.Contains(name)
                            select b;
                return blogs.ToList();
            }
        }
        //查找等于给定名称的博客
        public Blog QueryABlog(string name)
        {
            using (var db = new BloggingContext())
            {
                // 查询所有包含字符串name的博客
                var blogs = from b in db.Blogs
                            where b.Name == name
                            select b;
                return blogs.FirstOrDefault();
            }
        }
        public List <Post> Querypost(string title)
        {
            using (var db = new BloggingContext())
            {
                var posts = from b in db.Posts
                            where b.Title == title
                            select b;

                return posts.ToList();
            }
        }


        public Blog Query(int id)
        {
            using (var db = new BloggingContext())
            {
                return db.Blogs.Find(id);
            }
        }
        public void Delete(Blog blog)
        {
            using (var db = new BloggingContext())
            {
                db.Entry(blog).State = EntityState.Deleted;
                db.SaveChanges();
            }

        }
        //显示全部帖子
        public List<Post> Querypost()
        {
            using (var db = new BloggingContext())
            {
                return db.Posts.ToList();

            }

        }
        public void Delete2(Post post)
        {
            using (var db = new BloggingContext())
            {

                db.Entry(post).State = EntityState.Deleted;

                db.SaveChanges();
            }

        }
        //public void Deleteboid(int id)
        //{
        //    using (var db = new BloggingContext())
        //    {
        //        db.Blogs.Find(id);
        //        db.Entry(id.ToString()).State = EntityState.Deleted;
        //        db.SaveChanges();
        //    }

        //}
        public Post Query2(int id)
        {
            using (var db = new BloggingContext())
            {
                return db.Posts.Find(id);
            }
        }
        public void Update2(Post post)
        {
            using (var db = new BloggingContext())
            {
                db.Entry(post).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        public void Addpost(Post post)
        {
            using (var db = new BloggingContext())
            {
                db.Posts.Add(post);
                db.SaveChanges();
            }
        }
        public List<Post> QueryPost()
        {
            using (var db = new BloggingContext())
            {
                return db.Posts.ToList();

            }

        }




    }
}
