using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Object_Initializer
{
    public class Person
    {
        public string Name;
        public int Id;
        public DateTime Birthdate;

    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person()
            {
                Name = "usama jamil",
                Id = 33,
                Birthdate = new DateTime(1998, 1, 15)
            };

            Console.WriteLine(person.Id);
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Birthdate);

            Console.ReadKey();
        }
    }
}
