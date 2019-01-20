using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classes_intermidate
{
    public class Person
    {
        public string Name;

        public void Introduction(string to)
        {
            Console.WriteLine("Asslamo Alikum ! My name is {0}  Kaya hal hay {1} ", Name,to);
        }
        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = Person.Parse("usama jamil");
            person.Introduction("ali");
            Console.ReadKey();
        }
    }
}
