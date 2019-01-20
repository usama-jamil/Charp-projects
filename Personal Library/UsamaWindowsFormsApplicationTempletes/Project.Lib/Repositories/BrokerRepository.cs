using Project.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Lib.Repositories
{
  public  class BrokerRepository
    {
        public List<Broker> GetAll()
        {
            return new List<Broker>
            {
                new Broker { Name="jasmin", Id = 1 , Address ="karachi", PhoneNumber = "03000878634",JoinningDate = DateTime.Today.AddDays(1)},
                new Broker { Name="Saba", Id = 2 , Address ="toba tek singh", PhoneNumber = "0300863345",JoinningDate = DateTime.Today.AddDays(2)},
                new Broker { Name="hoor", Id = 3 , Address ="inglistan", PhoneNumber = "0312495865",JoinningDate = DateTime.Today.AddDays(3)},
                new Broker { Name="misbhaa", Id = 4 , Address ="gojra", PhoneNumber = "03320332332",JoinningDate = DateTime.Today.AddDays(4)},
                new Broker { Name="alif", Id = 5 , Address ="sindh", PhoneNumber = "03994057385",JoinningDate = DateTime.Today.AddDays(5)}
            };
        }

        public void Add(Broker broker)
        {

        }

        public void Delete(Broker broker)
        {

        }

        public void Update(Broker broker)
        {

        }
    }
}
