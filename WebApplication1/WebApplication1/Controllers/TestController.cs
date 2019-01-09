using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModel;



namespace WebApplication1.Controllers
{
    public class TestController : Controller
    {
        //public static void gg()
        //{
        //   int g = 5;
        //   object b =g ;
        //   int c = (int)b;

        //    Console.ReadLine();

        //}
        

        public string GetString()
        {
            return "你好MVC！"; 
        }
        public Customer getCustomer()
        {
            Customer c = new Customer();
            c.CustomerName = "梁俊";
            c.Address = "柳州职业技术学院";
            return c;
        }
        public ActionResult Save(Employee e,string BtnSubmit)
        {
            switch (BtnSubmit)
            {
                case "保存":
                    {
                        EmployeeBusinessLayer empBal = new EmployeeBusinessLayer();
                        empBal.Save(e);
                        return RedirectToAction("getview");

                    }
                    //return Content("姓名：" + e.Name + ",工资：" + e.Salary);
                case "取消":
                    return RedirectToAction("getview");
                        
            }
            return new EmptyResult();
            
            
        }
        public ActionResult AddNew()
        {
            return View("CreateEmployee");
        }
        public ActionResult GetView()
        {
            //string greeting;
            //DateTime dt = DateTime.Now;
            //int hour = dt.Hour;
            //if (hour < 12)
            //{
            //    greeting = "早上好!";
            //}
            //else
            //{
            //    greeting = "下午好!";
            //}
            //ViewData["greeting"] = greeting;
            //ViewBag.greet = greeting;
            //Employee e = new Employee();
            //e.Name = "梁俊";
            //e.Salary = 100;
            //ViewData["xx"] = e;
            EmployeeListViewModel employeeListViewModel = new EmployeeListViewModel();
          
            employeeListViewModel.Employees = getEmpVmList();

            employeeListViewModel.UserName = getUserName();
            employeeListViewModel.Greting = getGreeting();
            
            return View("MyV", employeeListViewModel);

            //Customer c = new Customer();
            //c.Address = "lzzy";
            //c.CustomerName = "弟弟";
            //ViewBag.Cust = c;
            //EmployeeViewModel vmEmp = new ViewModel.EmployeeViewModel();
            //vmEmp.EmployeeName = e.Name;
            //vmEmp.EmployeeSalary = e.Salary.ToString("C");
            //if (e.Salary > 1000)
            //{
            //    vmEmp.EmployeeGrade = "土豪";
            //}
            //else
            //{
            //    vmEmp.EmployeeGrade = "屌丝";
            //}
            //vmEmp.grting = greeting;
            ////vmEmp.UserName = "Admin";
            ////ViewBag.Empkey = e;
            //return View("MyView",vmEmp);
        }
        [NonAction]
        List<EmployeeViewModel>getEmpVmList()
        {
            EmployeeBusinessLayer empBal = new EmployeeBusinessLayer();
            List<Employee> employees = empBal.GetEmployees();
            List<EmployeeViewModel> empViewModels = new List<EmployeeViewModel>();
            foreach (Employee emp in employees)
            {
                EmployeeViewModel empViewModel = new EmployeeViewModel();
                empViewModel.EmployeeName = emp.Name;
                empViewModel.EmployeeSalary = emp.Salary.ToString("C");
                if (emp.Salary > 1000)
                {
                    empViewModel.EmployeeGrade = "土豪";

                }
                else
                {
                    empViewModel.EmployeeGrade = "屌丝";
                }
                empViewModels.Add(empViewModel);
            }
            return empViewModels;
        }
        [NonAction]
        string getGreeting()
        {
            string greeting;
            DateTime dt = DateTime.Now;
            int hour = dt.Hour;
            if (hour < 12)
            {
                greeting = "早上好!";
            }
            else
            {
                greeting = "下午好!";
            }
            return greeting;
        }
        [NonAction]
        string getUserName()
        {
            return "Admin";
        }
       

    }
}