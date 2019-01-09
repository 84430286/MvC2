using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.DataAccessLayer;

namespace WebApplication1.Models
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployees()
        {
            SalesERpDAL salesDal = new SalesERpDAL();
            return salesDal.TblEmployees.ToList();
            //List<Employee> employees = new List<Employee>();
            //Employee emp = new Employee();
            //emp.Name = "一";
            //emp.Salary = 1000;
            //employees.Add(emp);

            //emp = new Employee();
            //emp.Name = "二";
            //emp.Salary = 2000;
            //employees.Add(emp);

            //emp = new Employee();
            //emp.Name = "三";
            //emp.Salary = 3000;
            //employees.Add(emp);


            //return null;
            //return employees;

        }
        public Employee Save(Employee e)
        {
            SalesERpDAL salesDal = new SalesERpDAL();
            salesDal.TblEmployees.Add(e);
            salesDal.SaveChanges();
            return e;
        }
    }
}