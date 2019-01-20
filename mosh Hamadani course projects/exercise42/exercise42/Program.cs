using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exercise42
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ReadKey();
        }
    }
}
//var random = new Random();
//var guess = (byte)random.Next(1, 10);
//byte input  ;
//const int chance = 4;
//for (int i = 0; i < chance; i++)
//{
//    Console.WriteLine("Guess the number ");
//    input =byte.Parse( Console.ReadLine());
//    if (guess == input)
//    {
//        Console.WriteLine("You Won!...");
//        return;
//    }
//}
//Console.WriteLine("You Lose!...");
//Console.WriteLine("The number is {0}",guess);

//Console.WriteLine("enter number ");
//var fictorialNumber = int.Parse(Console.ReadLine());
//var fictorial = 1;
//for (int i = 1; i <=fictorialNumber ; i++)
//{
//    fictorial = fictorial * i;
//}
//Console.WriteLine("fictorial is " + fictorial);




//var input = "";
//            var sum = 0;
//            while (true)
//            {
//                Console.WriteLine("Enter a number Or enter ok to exit");
//                input = Console.ReadLine();
//                if (input == "ok" ||   string.IsNullOrWhiteSpace(input))
//                {
//                    break;
//                }
//                sum = sum +int.Parse(input);
//            }
//            Console.WriteLine("Sum of total number is : {0}",sum);

//var count = 0;
//            for (int i = 0; i < 100; i++)
//            {
//                if (i%3==0)
//                {
//                    count++;
//                    Console.WriteLine(i);
//                }
//            }
//            Console.WriteLine("Total number from 1 to 100 that divisibal with 3 are {0}",count);