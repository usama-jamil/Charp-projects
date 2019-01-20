using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_55
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberList = "2,3,4,5,6,6";


            var numbersSeprate = numberList.Split(',');
            var numbers = new int[numbersSeprate.Length];
            foreach (var number in numbersSeprate)
            {
                var i = 0;
                if (!string.IsNullOrWhiteSpace(numbersSeprate[i]) || numbers[i]>5)
                {
                    numbers[i] = Convert.ToInt32(number);
                    
                }
                i++;
            }


            var uniques = new List<int>();
            foreach (var number in numbers)
            {
                
            }
                    Console.ReadKey();
        }
    }
}
//var numbers = new List<int>();
//while (true)
//{
//    Console.WriteLine("Enter a number or type Quite to exit");
//    var input = Console.ReadLine();
//    if (input.Trim().ToLower() == "quite" )
//    {
//        break;
//    }
//    numbers.Add(Convert.ToInt32(input));
//    Console.Clear();
//}
//var uniques = new List<int>();
//foreach (var number in numbers)
//{
//    if (!uniques.Contains(number))
//    {
//        uniques.Add(number);
//    }
//}
//Console.WriteLine("the unique numbers are:");
//foreach (var unique in uniques)
//{
//    Console.WriteLine(unique);
//}
//Console.WriteLine("The original list is :");
//foreach (var number in numbers)
//{
//    Console.WriteLine(number);
//}







//var name = "";
//Console.WriteLine("Enter your name :");
//name = Console.ReadLine();
//var array = new char[name.Length];
//for (int i = 0; i <name.Length; i++)
//{
//    array[i] = name[(name.Length-1) - i];
//}
//var reverseName = new string(array);
//Console.WriteLine("Reverse name is :");
//    Console.Write(reverseName);


//var name = "";
//string  reveresName;
//Console.WriteLine("Enter your name :");
//name = Console.ReadLine();
//var  reverseNameArray = new List<char>(name.Reverse());                             yr nhi howa...Questin no 2
//Console.WriteLine("Reverse name is :");
//foreach (var reverseName in reverseNameArray)
//{
//    Console.Write(reverseName);

//}





//int number;
//var numbers = new List<int>();
//Console.WriteLine("Enter number :");
//number = Convert.ToInt32(Console.ReadLine());
//numbers.Add(number);
//numbers.

//    const int Length = 5;
//    var numbers = new int[Length];
//again:
//    Console.Clear();
//    for (int i = 0; i < Length; i++)
//    {
//            Console.WriteLine("Enter a number :");
//            numbers[i] = Convert.ToInt32(Console.ReadLine());
//        for(int j = 0;i>0 && j<i;j++)
//        {

//            if(numbers[j]==numbers[i])
//            {
//            Console.WriteLine("Error...");
//            Console.WriteLine("The number is not unique");
//            if ("l" == Console.ReadLine())
//                goto again;
//            else
//                return;
//            }

//        }


//    }
//    Console.WriteLine("The number are sorted :");
//    Array.Sort(numbers);
//    foreach (var number in numbers)
//    {
//        Console.WriteLine(number);
//    }







//var names = new List<string>();
//var name = ""; 
//while (true)
//{
//Console.WriteLine("Enter name:");
//name = Console.ReadLine();
//    if (name == " ")
//    {
//        break;		 
//    }
//names.Add(name.Trim());    
//}

//if (names.Count == 1)
// {
//Console.WriteLine("{0} Like your post",names[0]);		 
// }
//else if (names.Count == 2)
//{
//    Console.WriteLine("{0} and {1} Like your post", names[0], names[1]);
//}
//else
//{
//    var andOther = names.Count - 2;
//    Console.WriteLine("{0},{1} and {2} other like our post...",names[0],names[1],andOther);
//}