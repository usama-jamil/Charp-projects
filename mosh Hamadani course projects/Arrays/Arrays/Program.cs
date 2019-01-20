using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new [] { 1, 6, 9, 44, 63, 77, 87, 4, 13 };
            var another = new int[numbers.Length];
            Console.WriteLine("length of another array is :"+another.Length);
            Console.WriteLine("Rank of the array numbers is :"+another.Rank);
            Console.WriteLine(numbers.Max());
            Array.Sort(numbers);
            Console.WriteLine("sort Method");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);   
            }
            Array.Reverse(numbers, 3, 5);
            Console.WriteLine("reveres Method");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine(1+Array.IndexOf(numbers, 1));
            Console.ReadKey();
        }
    }
}
