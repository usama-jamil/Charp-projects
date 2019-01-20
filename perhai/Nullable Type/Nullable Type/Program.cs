using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = 444;

            int b = a.GetValueOrDefault();

            Console.WriteLine(a.GetValueOrDefault());
            Console.WriteLine(a.HasValue);
            Console.WriteLine(b);

            Console.ReadKey();
        }
    }
}
