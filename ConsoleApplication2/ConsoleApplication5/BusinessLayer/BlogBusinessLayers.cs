using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication5.Models;
using ConsoleApplication5.DataAccessLayer;

namespace ConsoleApplication5.BlogBusinessLayer
{
   public class BlogBusinessLayers
    {
        public void Add(Grade blog)
        {
            using (var db=new BloggingContext())
            {
                db.Blogs.Add(blog);
                db.SaveChanges();
            }
        }
        public List<Grade> Query()
        {
            using (var db = new BloggingContext())
            {
                return db.Blogs.ToList();

            }
                
        }
            
    }
}
