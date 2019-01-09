using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModel;

namespace WebApplication1.Controllers
{
    public class MytextController : Controller
    {
        // GET: Mytext
        public ActionResult Index()
        {
            Customer c = new Customer();
            Employee e = new Employee();
            c.CustomerName = "弟弟";
            c.Address = "柳州职业技术学院";
            e.Name = "梁俊";
            e.Salary = 100;
            ViewData["emp"] = e;
            //ViewBag.Cust = c;
            return View(c);
        }
    }
}