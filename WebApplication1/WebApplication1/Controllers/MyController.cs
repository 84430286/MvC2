using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModel;

namespace WebApplication1.Controllers
{
    public class MyController : Controller
    {
        // GET: My
        public ActionResult Index()
        {
            CustomerListViewModel customerListViewModel = new CustomerListViewModel();
            CustomerBusinessLayer cusBal = new CustomerBusinessLayer();
            List<Customer> customer = cusBal.GetCustomer();
            List<CustomerViewModel> cusViewModels = new List<CustomerViewModel>();
            foreach (Customer cus in customer)
            {
                CustomerViewModel cusViewModel = new CustomerViewModel();
                cusViewModel.CustomerName = cus.CustomerName;
            }







            return View();
        }
    }
}