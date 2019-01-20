using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Lib.Models
{
  public  class SaleInvoice
    {
        public int Id { get; set; } = -1;

        public int ReciptNo { get; set; }
        public List<Product> Products { get; set; }
        public DateTime InvoiceDate { get; set; } = DateTime.Today;

        public SalePerson SalePerson { get; set; }

        public string Comment { get; set; }

        public PaymentMethod PaymentMethod { get; set; }

        public decimal GrandTotal { get { return Products.Sum(p => p.SalePrice); } }

    }
}
