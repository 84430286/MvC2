using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class CustomerBusinessLayer
    {
        public List<Customer> GetCustomer()
        {
            List<Customer> customer = new List<Customer>();
            Customer cus = new Customer();
            cus.CustomerName = "11";
            cus.Address = "lzzy";
            customer.Add(cus);

            cus = new Customer();
            cus.CustomerName = "22";
            cus.Address = "lzzy";
            customer.Add(cus);

            cus = new Customer();
            cus.CustomerName = "33";
            cus.Address = "lzzy";
            customer.Add(cus);

            return customer;

        }
    }
}