using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace looops
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            const int passwordLength = 10;
            var buffer = new char[passwordLength];
            for (int i = 0; i < passwordLength; i++)
            {

                
                buffer[i] = (char)('a' + random.Next(0,26));
                var password = buffer[i];
                Console.Write(password);
            }


            Console.ReadKey();
        }
    }
}
            //while (true)
            //{
            //    Console.WriteLine("enter Your Name");
            //    var input = Console.ReadLine();
            //    if (string.IsNullOrWhiteSpace(input))
            //    {
            //        break;
            //    }
            //    Console.WriteLine(input );


//var name = "usama jamil";
//for (int i = 0; i <name.Length; i++)
//{
//    Console.WriteLine(name[i]);
//}
//foreach (var character in name )
//{
//    Console.WriteLine(character);
//}
//var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
//foreach (var number in numbers)
//{
//    Console.WriteLine(number);
//}