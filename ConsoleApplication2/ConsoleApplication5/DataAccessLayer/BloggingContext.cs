using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ConsoleApplication5.Models;
namespace ConsoleApplication5.DataAccessLayer
{
   public class BloggingContext:DbContext
    {
        public DbSet<Grade> Blogs { get; set; }
        public DbSet<Student> Posts { get; set; }
    }
}
