using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Methods
{
    
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                int num = int.Parse("abc");

            }
            catch (Exception)
            {

                Console.WriteLine("Conversion is no applicable :");
            }
            int number;
            var result = int.TryParse("asd", out number);
            if (result)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Conversion is no applicable :");
            }
          Console.ReadKey();
        }
        public static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2, 3, 4, 5, 6, 6, 60));
        }
        public static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(30, 40);
                Console.WriteLine("Point is moving {0} , {1}", point.X, point.Y);
                point.Move(null);
                Console.WriteLine("Point is moving {0} , {1}", point.X, point.Y);
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("An error occured");
                Console.ReadKey();
            }
        }
        
    }
}
