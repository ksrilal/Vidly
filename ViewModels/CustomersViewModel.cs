using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class CustomerViewModel
    {
        public List<Customer> Customers { get; set; }

        public CustomerViewModel()
        {
            Customers = new List<Customer>
            {
                new Customer {Id=1, Name="Bob"},
                new Customer {Id=2, Name="John"},
                new Customer {Id=3, Name="Mosh"},
                new Customer {Id=4, Name="Lal"}
            };
        }
    }
}