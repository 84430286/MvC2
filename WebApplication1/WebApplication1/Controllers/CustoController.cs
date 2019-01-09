using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CustoController : Controller
    {
        // GET: Custo
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public ActionResult CusView()
        {
            string greeting;
            DateTime dt = DateTime.Now;
            int hour = dt.Hour;
            if (hour < 12)
            {
                greeting = "早上好";
            }
            else
            {
                greeting = "下午好";
            }
            ViewData["greeting"] = greeting;
            //ViewBag.greet = greeting;
            Customer c = new Customer();
            c.CustomerName = "弟弟";
            c.Address= "柳州职业技术学院";
            //ViewData["xx"] = e;
            ViewBag.Empkey = c;
            return View("CusView", c);
        }
    }
}