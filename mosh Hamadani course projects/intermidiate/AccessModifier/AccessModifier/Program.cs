using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccessModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthdate(new DateTime(1998,1,15));
            Console.WriteLine(person.GetBirthdate());
            Console.ReadKey();
        }
    }
}
