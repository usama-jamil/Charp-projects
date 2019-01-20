using Project.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsamaWindowsFormsApplicationTempletes.Interface
{
   public interface IProductRequester
    {
        List<Supplier> Suppliers { get; }

        List<Category> Categories { get; }
 
        void CompleteProduct(Product product);
    }
}
