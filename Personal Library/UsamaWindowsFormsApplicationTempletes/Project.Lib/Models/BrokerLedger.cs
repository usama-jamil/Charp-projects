using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Lib.Models
{
   public class BrokerLedger
    {
        public int Id { get; set; }

        public Broker Broker { get; set; }

        public decimal InvoiceBill { get; set; }

        public decimal PaidAmount { get; set; }

        public decimal MyProperty { get; set; }
        public DateTime InvoiceDate { get; set; }


    }
}
