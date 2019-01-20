using Project.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Lib.Repositories
{
    public class CustomerRepository
    {

        public List<Customer> GetAll()
        {
            return new List<Customer>
            {
                new Customer
                {
                    Id =1,
                    Name = "ali",
                    Address = "",
                    Balance = 40358.54M,
                    PhoneNo = "",
                    JoinningDate = DateTime.Today.AddDays(1),
                    ProductName=  ""
                },
                new Customer
                {
                    Id =1,
                    Name = "bhadur",
                    Address = "",
                    Balance = 40358.54M,
                    PhoneNo = "",
                    JoinningDate = DateTime.Today.AddDays(1),
                    ProductName=  ""
                },
                new Customer
                {
                    Id =1,
                    Name = "lol",
                    Address = "",
                    Balance = 40358.54M,
                    PhoneNo = "",
                    JoinningDate = DateTime.Today.AddDays(1),
                    ProductName=  ""
                },
                new Customer
                {
                    Id =1,
                    Name = "num",
                    Address = "",
                    Balance = 40358.54M,
                    PhoneNo = "",
                    JoinningDate = DateTime.Today.AddDays(1),
                    ProductName=  ""
                }
            };

        }

        public void Add(Customer customer)
        {

        }

        public void Delete(Customer customer)
        {

        }

        public List<Customer> Search(string search)
        {
            return new List<Customer>();
        }

    }
        

}
