using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_SalesDatabase.Models
{
    internal class Sale
    {
        public int SaleId { get; set; }
        public List<Product> Products { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Store> Stores { get; set; }
    }
}
