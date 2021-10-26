using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customer/CustomerList
        public ActionResult CustomerList()
        {
            var customersViewModel = new CustomerViewModel();
            return View(customersViewModel);
        }

        public ActionResult Customer(int id)
        {
            var customersViewModel = new CustomerViewModel();
            var customer = customersViewModel.Customers.Single(c => c.Id.Equals(id));
            return View(customer);
        }
    }
}