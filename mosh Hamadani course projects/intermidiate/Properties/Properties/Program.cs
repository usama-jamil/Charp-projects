using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Properties
{
    public class Person
    {
        private string Name;

        public DateTime Birthdate { get; private set; }
        public Person(DateTime birthdate)
        {
            this.Birthdate = birthdate;
        }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Now - Birthdate;
                return timeSpan.Days / 365;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1998, 1, 15));
            Console.WriteLine(person.Age);
            var obj = new Object();
            obj = person;
            Console.WriteLine(obj.ToString());
            Console.ReadKey();
        }
    }
}
