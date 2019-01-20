using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NewLineCharacter.Math;

namespace NewLineCharacter
{
    enum Season
    {
        Summer,
        Spring,
        Autum,
        Winter
    }
    class Program
    {
        static void Main(string[] args)
        {
            string  seasonName;
            seasonName = Console.ReadLine();
            //var  season = Enum.Parse(typeof(Season), seasonName);
            var season = Season.Autum;
             Console.WriteLine(season);
            switch (season)
            {
                case Season.Summer:
                    Console.WriteLine("it's very hot");
                    break;
                case Season.Spring:
                    Console.WriteLine("acha mosam hay");
                    break;
                case Season.Autum:
                    Console.WriteLine("Patay Gir Rhay hay");
                    break;
                case Season.Winter:
                    Console.WriteLine("A sai Mosam aa");
                    break;
                default:
                    break;
            }

            Console.ReadKey();
            

        }
    }
}
         
      /*  public static  void Increment(int number)
        {
            number += 10;
        }
        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
            var number = 1;
            Increment(number);
            Console.WriteLine(number);
            var person = new Person() { Age = 20 };
            MakeOld(person);
            Console.WriteLine(person.Age);*/
//int a = 10;
  //          var b = a;
    //        b++;
      //      Console.WriteLine("a : {0}  b : {1}", a, b);
        //    var array = new   int [3] {1,2,3};
          //  var array1 = array;
            //Console.WriteLine("array : {0} array1 : {1}",array[1],array1[1]);
        //    array[1] = 5;
          //  Console.WriteLine("array : {0} array1 : {1}", array[1], array1[1]);


// var method = ShippingMethod.Express;
            //Console.WriteLine((byte)method);               //this is show the enum number
  //          var methodId = 3;
    //        var methodName = "Express";
          //  var shippingMethod = Enum.Parse(typeof(ShippingMethod), methodName );       //this use string to enum
           // Console.WriteLine(shippingMethod);
        //    Console.WriteLine((ShippingMethod)methodId); //this use int to enum
      //      Console.WriteLine(typeof(int));
/* person ali = new person();
            ali.FirstName = "ali";
            ali.LastName = "dhillon";
            ali.Introduce();
            Calculator cal = new Calculator();                //this coding use to class in other file
            int result = cal.Add(33, 55);
            Console.WriteLine(result);
            Console.ReadKey();
            */


/*
           // Console.Write("mango man\n");
            string firstName;
            string lastName;
            //computerName = "usama jamil";
            Console.WriteLine("apna name likhay");                  //string interpolation
            firstName = Console.ReadLine();
            Console.WriteLine("apna abbu name likhay");
            lastName= Console.ReadLine();
            Console.WriteLine("aap ka name hay "+ firstName + lastName);
            //Console.WriteLine("ccc");
           */




/*int firstNumber, secondNumber;
int addResult;
Console.WriteLine("enter number");
firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("enter number");
secondNumber = int.Parse(Console.ReadLine());          //retrive data
addResult = firstNumber + secondNumber;
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine(addResult);*/



/*Console.WriteLine("usama jamil");
Console.Write("usama jamil");
Console.Write("\nbatmintion\n");             //assingment
string color = "blue";
Console.WriteLine(color);
string hobby;
hobby = Console.ReadLine();
Console.WriteLine(hobby);
*/

/*int firstNumber, secondNumber;
Console.WriteLine("Enter namuber");
firstNumber = int.Parse( Console.ReadLine());
Console.WriteLine("Enter namuber");
secondNumber = int.Parse(Console.ReadLine());

if (firstNumber == secondNumber)
{
    Console.WriteLine("the number are equal{0:G}" , firstNumber );
}
else
{
    Console.WriteLine("the number are not equal");
}
             
*/


/*  Console.WriteLine("{0} {1}",int.MaxValue,int.MinValue);
  const float Pi =3.14f;
  Console.WriteLine(Pi);
  Console.ReadKey();
 */



/* int a = 1000;
 byte b = (byte) a;           //type conversion
 Console.WriteLine(b);
 // Non Compatibale types
 try
 {
     string o = "true";
     Boolean d = Convert.ToBoolean(o);          //Explicit type Conversion
     Console.WriteLine(d);
     Console.ReadKey();

 }
 catch (Exception)
 {

     Console.WriteLine("pagal galat coding kiti aa");
     Console.ReadKey();
 }*/