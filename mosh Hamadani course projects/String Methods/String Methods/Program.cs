using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace String_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder();
            builder
                .Append('o', 20)
                .AppendLine()
                .AppendFormat("hello World")
                .;
            Console.WriteLine(builder);
            Console.ReadKey();
        }
    }
}
//var fullName = "usama jamil  ";
//Console.WriteLine(fullName.Trim());
//Console.WriteLine(fullName.ToUpper());
//Console.WriteLine(fullName.Trim().ToUpper());
////split my name
//var index = fullName.IndexOf(' ', 0);
//var firstName = fullName.Substring(0, index);
//var lastName = fullName.Substring(index + 1);
//Console.WriteLine("First name :"+firstName);
//Console.WriteLine("Last Name :"+lastName);
//var names = fullName.Split(' ');
//Console.WriteLine("First Name :"+ names[0]);
//Console.WriteLine("Last Name :"+ names[1]);
//Console.WriteLine(fullName.Replace("usama","programmer"));
//Console.WriteLine(fullName.Remove(5));
//var str = "99";
//var price = 786;
//Console.WriteLine(Convert.ToByte(str));
//Console.WriteLine(price.ToString());