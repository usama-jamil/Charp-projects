using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Constructor_Inheritance
{
    public class Car : Vehicle
    {
        public Car()
        {
            Console.WriteLine("The car has just initializee :");
        }
        public Car(string registerationNumber)
            :base(registerationNumber)
        {
            Console.WriteLine("The car has just initializee : {0}",registerationNumber);
        }
    }
}
