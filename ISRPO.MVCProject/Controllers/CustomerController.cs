using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ISRPO.MVCProject.Models;

namespace ISRPO.MVCProject.Controllers
{
    public class CustomerController : Controller
    {
        private static Shop _shop = new Shop();
        
        public IActionResult Index()
        {
            return View("Index");
        }
        public IActionResult GetCreate()
        {
            return View("EditCreate", new Customer() { Id = _shop.Customers.Count + 1});
        }
        public IActionResult CreateAndExit( Customer customer)
        {
            
            if (!TryValidateModel(customer)) 
            {
                return View("EditCreate");
            }
            if (!_shop.Customers.FindAll(f => f.Id == customer.Id).Any())
            {
                customer.Id = _shop.Customers.Count + 1;
            }
            else
            {
                var temp = _shop.Customers.Find(f => f.Id == customer.Id);
                _shop.Customers.RemoveAt(_shop.Customers.IndexOf(temp));
            }
            _shop.Customers.Add(customer);
            return View("Index", _shop);
        }

        public IActionResult EditCustomer(int id)
        {
            return View("EditCreate", _shop.Customers.Find(f => f.Id == id));
        }

        public IActionResult DeleteCustomer(int id)
        {
            _shop.Customers.RemoveAt(_shop.Customers.IndexOf(_shop.Customers.Find(f => f.Id == id)));
            return View("Index", _shop);
        }



    }
}
