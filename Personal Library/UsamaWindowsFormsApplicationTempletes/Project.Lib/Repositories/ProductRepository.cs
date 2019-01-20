using Project.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Lib.Repositories
{
   public class ProductRepository
    {
        public List<Product> GetAll()
        {
            return new List<Product>
            {
                new Product { Name = "Milk",   Description = "bohat hi white hota hay", Supplier = new SupplierRepository().GetAll()[0],Broker = new BrokerRepository().GetAll()[0],Id = 1 ,Quantity = 10,RetailPrice = 500,Tax = 110,Category = new CategoryRepository().GetAll()[0]},
                new Product { Name = "Eggs",   Description = "bohat hi gool hota hay", Supplier = new SupplierRepository().GetAll()[1],Broker = new BrokerRepository().GetAll()[1] ,Id = 2,Quantity = 20,RetailPrice = 400,Tax = 90,Category = new CategoryRepository().GetAll()[1]},
                new Product { Name = "Cake",   Description = "bhoat hi mitha hota hay ", Supplier = new SupplierRepository().GetAll()[2],Broker = new BrokerRepository().GetAll()[2],Id = 3 ,Quantity = 30,RetailPrice = 300,Tax = 70,Category = new CategoryRepository().GetAll()[2]},
                new Product { Name = "Mangoo", Description = "bohat hi yellow hota hay", Supplier = new SupplierRepository().GetAll()[3],Broker = new BrokerRepository().GetAll()[3] ,Id = 4,Quantity = 40,RetailPrice = 200,Tax = 50,Category = new CategoryRepository().GetAll()[0]},
                new Product { Name = "Aloo",   Description = "Chips or Pakoray achay bantay hay", Supplier = new SupplierRepository().GetAll()[4],Broker = new BrokerRepository().GetAll()[4],Id = 5,Quantity = 50 ,RetailPrice = 100,Tax = 30,Category = new CategoryRepository().GetAll()[1]}
            };
        }

        public void SubQuantity(Product product)
        {
            //throw new NotImplementedException();
        }

        public void AddQuantity(Product product)
        {
            //throw new NotImplementedException();
        }

        public bool IsProductQuantityInStock(Product product)
        {
            return true;
        }

        public void Add(Product product)
        {

        }

        public void Delete(Product product)
        {

        }

        public void Search(string search)
        {

        }
    }
}
