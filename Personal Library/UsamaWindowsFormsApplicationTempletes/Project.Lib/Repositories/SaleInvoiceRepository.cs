using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Lib.Models;

namespace Project.Lib.Repositories
{
    public class SaleInvoiceRepository
    {
        ProductRepository productRepo = new ProductRepository();

        public void Add(SaleInvoice saleInvoice)
        {
            saleInvoice.Id = 1;

            saleInvoice.Products.ForEach(p => productRepo.SubQuantity(p));
        }

        public void Delete(SaleInvoice SaleInvoice)
        {
            if (SaleInvoice.Id == -1) return;
        }

        public void Update(SaleInvoice saleInvoice)
        {
            saleInvoice.Products.ForEach(p => productRepo.SubQuantity(p));

        }

        public void Save(SaleInvoice saleInvoice)
        {
            if (saleInvoice.Id == -1)
            {
                this.Add(saleInvoice);
            }
            else
            {
                this.Update(saleInvoice);
            }
        }
        public List<SaleInvoice> GetAllToday()
        {
            return new List<SaleInvoice>();
        }

        public List<SaleInvoice> GetAllByDate(DateTime date)
        {
            return new List<SaleInvoice>();
        }

        public List<SaleInvoice> GetAll()
        {
            return new List<SaleInvoice>();
        }

        public List<Product> FindProductsBySalePerson(List<SaleInvoice> saleIvoices, SalePerson salePerson)
        {
            if (saleIvoices.Find(p => p.SalePerson.Id == salePerson.Id) != null)
            {
                return saleIvoices.Find(p => p.SalePerson.Id == salePerson.Id).Products;
            }
            else
            {
                saleIvoices.Add(new SaleInvoice { SalePerson = salePerson , Products = new List<Product>()});
            }

            return saleIvoices.Find(p => p.SalePerson.Id == salePerson.Id).Products;

        }

        public SaleInvoice FindInvoiceBySalePerson(List<SaleInvoice> saleIvoices, SalePerson salePerson)
        {

            return saleIvoices.Find(p => p.SalePerson.Id == salePerson.Id);
        }
    }
}
