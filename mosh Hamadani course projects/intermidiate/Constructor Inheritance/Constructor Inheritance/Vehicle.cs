using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Constructor_Inheritance
{
   public  class Vehicle
    {
       private readonly string _registerationNumber;

       public Vehicle()
       {
           Console.WriteLine("The vehicle has just initialized :");
       }
       public Vehicle(string registerationNumber)
       {
           this._registerationNumber = registerationNumber;
           Console.WriteLine("The vehicle has just initialized : {0}",registerationNumber);
       }
    }
}
