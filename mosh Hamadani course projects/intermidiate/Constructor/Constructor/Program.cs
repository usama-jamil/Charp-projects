using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            var costomer = new Costomer
                { Id = 99,
                  Name ="usama jamil"
                };
            
            Console.WriteLine(costomer.Id);
            Console.WriteLine(costomer.Name);
            Console.ReadKey();
        }
    }
}
