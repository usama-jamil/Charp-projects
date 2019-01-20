using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Lib.Models
{
   public class SalePerson
    {
        public int Id { get; set; }

        public string CNIC { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public decimal Salary { get; set; }

        public DateTime JoinningDate { get; set; }

        public string PhoneNo { get; set; }

        public decimal Balance { get; set; }

    }
}
