using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication3.Models;
using ConsoleApplication3.DataAccessLayer;
using System.Data.Entity;

namespace ConsoleApplication3.SchoolinLayer
{
   public class SchoolLayer
    {
        public void Add(Grade grade)
        {
            using (var db=new StudentClass())
            {
                db.Grades.Add(grade);
                db.SaveChanges();
                //db.Grades.Add(grade);
                //db.SaveChanges();
            }
        }
        public List<Grade> Query()
        {
            using (var db = new StudentClass())
            {
                return db.Grades.ToList();

            }

        }
        public void Update(Grade grade)
        {
            using(var db=new StudentClass())
            {
                db.Entry(grade).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        public Grade Query(int id)
        {
            using(var db=new StudentClass())
            {
                return db.Grades.Find(id);
            }
        }
        public void Delete(Grade grade)
        {
            using (var db = new StudentClass())
            {
                db.Entry(grade).State = EntityState.Deleted;
                db.SaveChanges();
            }

        }
    }
}
