using Project.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Lib.Repositories
{
  public  class SupplierRepository
    {
        public List<Supplier> GetAll()
        {
            return new List<Supplier>
            {
                new Supplier
                {
                    Id = 1,
                    Name ="ali",
                    Address = "faisalabad",
                    PhoneNumber = "03009878665",
                    JoinningDate = DateTime.Today.AddDays(1),
                },
                   new Supplier
                {
                    Id = 2,
                    Name ="muna",
                    Address = "fazoolistan",
                    PhoneNumber = "03003023014",
                    JoinningDate = DateTime.Today.AddDays(2),
                },
                      new Supplier
                {
                    Id = 3,
                    Name ="zahoor",
                    Address = "lahore",
                    PhoneNumber = "0300876428",
                    JoinningDate = DateTime.Today.AddDays(3),
                },
                         new Supplier
                {
                    Id = 4,
                    Name ="pandu",
                    Address = "afghanistan",
                    PhoneNumber = "03329869213",
                    JoinningDate = DateTime.Today.AddDays(4),
                },
                         new Supplier
                {
                    Id = 5,
                    Name ="zagam",
                    Address = "thar",
                    PhoneNumber = "03324869395",
                    JoinningDate = DateTime.Today.AddDays(5),
                }
            };
        }

        public void Add(Supplier supplier)
        {

        }

        public void Delete(Supplier supplier)
        {

        }

        public List<Supplier> Search(string search)
        {
            return new List<Supplier>();
        }
    }
}
