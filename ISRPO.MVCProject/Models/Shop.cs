using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISRPO.MVCProject.Models
{
    public class Shop
    {
        public List<Customer> Customers { get; set; }
        public Shop()
        {
            Customers = new List<Customer>();
        }
    }
}
