using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Lib.Models
{
   public class PurchaseInvoice
    {
        public int Id { get; set; } = -1;
        public int InvoiceNo { get; set; }
        public List<Product> Products { get; set; }
        public Broker Broker { get; set; }
        
        public DateTime InvoiceDate { get; set; } = DateTime.Today;
        public PaymentMethod PaymentMethod { get; set; }

        public string Comment { get; set; }


        public decimal GrandTotal { get { return Products.Sum(p => p.NetPrice); } }
    }
}
