using Project.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Lib.Repositories
{
    public class SalePersonRepository
    {

        public List<SalePerson> GetAll()
        {

            return new List<SalePerson>
            {
                new SalePerson {Id = 1 , Name ="Nomi" , Address ="inglistan" , Salary = 12000 , JoinningDate = DateTime.Today.AddDays(1) , PhoneNo = "03994057385"},
                new SalePerson {Id = 2 , Name ="Haider" , Address ="karachi" , Salary = 15000 , JoinningDate = DateTime.Today.AddDays(2) , PhoneNo = "03320332332"},
                new SalePerson {Id = 3 , Name ="Shad" , Address = "toba tek singh", Salary = 20000 , JoinningDate = DateTime.Today.AddDays(3) , PhoneNo = "0312495865"},
                new SalePerson {Id = 4 , Name ="Ali" , Address = "sindh" , Salary = 25000 , JoinningDate = DateTime.Today.AddDays(4) , PhoneNo ="0300863345" },
                new SalePerson {Id = 5 , Name ="Zahoor" , Address ="gojra" , Salary = 30000 , JoinningDate = DateTime.Today.AddDays(5) , PhoneNo ="03000878634" }
            };
        }

        public void Add(SalePerson salePerson)
        {

        }

    }
}
