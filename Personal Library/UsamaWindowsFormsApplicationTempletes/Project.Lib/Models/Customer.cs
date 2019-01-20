using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Lib.Models
{
   public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }
        public string ProductName { get; set; }


        public decimal Balance { get; set; }
        public DateTime JoinningDate { get; set; }
    }
}
