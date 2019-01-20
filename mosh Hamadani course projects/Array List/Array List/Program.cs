using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() {1,2,3,5,4,5};
            //numbers.Add(0);
            //var range = new int[] {5,6,7,8};
            //numbers.AddRange(range);
            //numbers.Insert(0, 9);
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 5)
                {
                    Console.WriteLine("The Index of 5 is :" + i); 
                    
                }
                
            }
             Console.WriteLine("The capacity of List is " + numbers.Capacity);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.ReadKey();
        }
    }
}
