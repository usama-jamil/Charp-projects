using System;

namespace NewLineCharacter
{
    public class person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + "  " + LastName);
        }
    }
}
