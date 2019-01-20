using Project.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Lib.Repositories
{
    public class PurchaseInvoiceRepository
    {
        ProductRepository productRepo = new ProductRepository();

        private List<PurchaseInvoice> _DataBase = new List<PurchaseInvoice>();
            //{
            //    new PurchaseInvoice {Broker = new BrokerRepository().GetAll()[0], Products = new ProductRepository().GetAll().Take(2).ToList(),Id= 1,InvoiceNo = 12 },
            //    new PurchaseInvoice {Broker = new BrokerRepository().GetAll()[1], Products = new ProductRepository().GetAll().Take(3).ToList(),Id= 2 ,InvoiceNo = 977},
            //    new PurchaseInvoice {Broker = new BrokerRepository().GetAll()[2], Products = new ProductRepository().GetAll().Take(4).ToList(),Id= 3,InvoiceNo =768 },
            //    new PurchaseInvoice {Broker = new BrokerRepository().GetAll()[3], Products = new ProductRepository().GetAll().Take(5).ToList(),Id= 4 },

            //};
        public void Add(PurchaseInvoice purchaseInvoice)
        {
            _DataBase.Add(purchaseInvoice);


            purchaseInvoice.Products.ForEach(p => productRepo.AddQuantity(p));
        }

        public void Delete(PurchaseInvoice PurchaseInvoice)
        {

        }

        public  void Update(PurchaseInvoice purchaseInvoice)
        {
            purchaseInvoice.Products.ForEach(p => productRepo.AddQuantity(p));

        }

        public void Save(PurchaseInvoice purchaseInvoice)
        {
            if (purchaseInvoice.Id == -1)
            {
                this.Add(purchaseInvoice);
            }
            else
            {
                this.Update(purchaseInvoice);
            }
        }

        public List<PurchaseInvoice> GetAllToday()
        {
            return _DataBase;

            //return GetAllDate(DateTime.Today);
        }

        public List<Product> FindProductsByBroker(List<PurchaseInvoice> purchaseInvoice , Broker broker)
        {
            if (purchaseInvoice.Find(p => p.Broker.Id == broker.Id) != null)
            {
                 
               return   purchaseInvoice.Find(p => p.Broker.Id == broker.Id).Products;
            }
            else
            {
                purchaseInvoice.Add(new PurchaseInvoice { Broker = broker, Products = new List<Product>() });
            }
            return purchaseInvoice.Find(p => p.Broker.Id == broker.Id).Products;
        }

            public PurchaseInvoice FindInvoiceByBroker(List<PurchaseInvoice> saleInvoice , Broker broker)
        {
            return saleInvoice.Find(b => b.Broker.Id == broker.Id);
        }
        public List<PurchaseInvoice> GetAllByDate(DateTime Date)
        {
            return new List<PurchaseInvoice>();
        }

        public List<PurchaseInvoice> GetAll()
        {
            return new List<PurchaseInvoice>();
        }
    }
}
