using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_48
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter speed limit :");
            int speedLimit = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter speed of a Car :");
            int carSpeed = Convert.ToInt16(Console.ReadLine());
            var suspendLicencePoints = 12;
            if (carSpeed < speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                var points = DemeritPoints(speedLimit, carSpeed);
                if (points >= suspendLicencePoints)
                {
                    Console.WriteLine("Licence Suspend");
                    Console.WriteLine(points);
                }
                else
              	{
                    Console.WriteLine("you are above the limit:" + points);
	            }
            }
            Console.ReadKey();
        }
        static int DemeritPoints(int speedLimit, int carSpeed)
        {
            var aboveSpeed = carSpeed - speedLimit;
            var points = aboveSpeed / 5;
            return points;
        }
    }
}

//Console.WriteLine("Enter Length :");
//int Length = Convert.ToInt16(Console.ReadLine());
//Console.WriteLine("Enter Width :");
//int Width = Convert.ToInt16(Console.ReadLine());
//if (Length>Width)
//{
//    Console.WriteLine("This image is Potrait ");
//}
//else
//{
//    Console.WriteLine("This image is Landscape");

//}




//Console.WriteLine("Enter first number :");
//int firstNumber = Convert.ToInt16(Console.ReadLine());
//Console.WriteLine("Enter second number :");
//int secondNumber = Convert.ToInt16(Console.ReadLine());
//if (firstNumber>secondNumber)
//{
//    Console.WriteLine("The greatest number is : {0}", firstNumber);
//}
//else
//{
//    Console.WriteLine("The greatest number is : {0}", secondNumber);

//}




//Console.WriteLine("Enter a Number :");
//string str ;
//str = Console.ReadLine();
//int number = Convert.ToInt16(str);
//var maxRange = 10;
//var minRange = 1;
//if (number >= minRange && number <= maxRange)
//{
//    Console.WriteLine("Valid");
//}
//else
//{
//    Console.WriteLine("Invalid");
//}