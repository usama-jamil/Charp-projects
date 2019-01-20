using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Lib.Models
{
   public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; } = 1;

        public decimal RetailPrice { get; set; }

        public decimal Worth { get { return Quantity * RetailPrice; } }

        public decimal Tax { get; set; }

        public decimal NetPrice { get { return RetailPrice + Tax; } }

        public decimal Margin { get; set; }

        public decimal SalePrice { get { return Margin + NetPrice; } }

        public string Description { get; set; }

        public Broker Broker { get; set; }
        public Supplier Supplier { get; set; }
        public Category Category { get; set; }
    }
}
