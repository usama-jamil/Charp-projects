using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fields
{
    class Program
    {
        static void Main(string[] args)
        {
            var costomor = new Costomer(1);
            costomor.Order.Add(new Order());
            costomor.Order.Add(new Order());

            Console.WriteLine(costomor.Order.Count);
            Console.ReadKey();
        }
    }
}
