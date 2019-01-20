using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Lib.Models
{
   public class Broker
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public decimal Balance { get; set; }
        public decimal Commession { get; set; }

        public DateTime JoinningDate { get; set; } = DateTime.Now;
    }
}
