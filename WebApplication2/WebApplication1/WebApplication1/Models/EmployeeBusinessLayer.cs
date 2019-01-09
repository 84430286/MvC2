using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.DataAccessLayer;
using System.Data.Entity;


namespace WebApplication1.Models
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployeeList()
        {
            using (SalesERPDAL dal = new SalesERPDAL())
            {
              
                var list = dal.Employees.ToList();
                return list;
            }   
        }
        public Employee SaveEmployee(Employee e)
        {
            SalesERPDAL salesDal = new SalesERPDAL();
            salesDal.Employees.Add(e);
            salesDal.SaveChanges();
            return e;
        }
        
        public void Delete(int id)
        {
            using (var db = new SalesERPDAL())
            {
                Employee emp = db.Employees.Find(id);
                db.Entry(emp).State = EntityState.Deleted;
                db.SaveChanges();
            }

        }
        public Employee Query(int id)
        {
            using(var db=new SalesERPDAL())
            {
                Employee emp = db.Employees.Find(id);
                return emp;
            }
        }
        public void Updele(Employee e)
        {
            using(var db=new SalesERPDAL())
            {
                
                db.Entry(e).State = EntityState.Modified;
                db.SaveChanges();
                
            }
        }
        public List<Employee> Query2(string name)
        {
            using (var db = new SalesERPDAL())
            {
                
                var emp = from b in db.Employees
                            where b.Name.Contains(name)
                            select b;
                return emp.ToList();
            }
        }
    }
}