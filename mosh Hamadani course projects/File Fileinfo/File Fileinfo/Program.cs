using System;
using System.IO;

namespace File_Fileinfo
{
    class Program
    {
        static void Main(string[] args)
        {
            //File.Create("usama.txt");
            //File.Open("usama.txt", FileMode.Open, FileAccess.Write);
            //var file = new FileInfo("usama.txt");
            //file.Open(FileMode.Open, FileAccess.ReadWrite);
            
            var fileStream = new FileStream("usama.txt",FileMode.Open,FileAccess.ReadWrite);
            
            var txtFile = "";
            for (int i = 0; i < fileStream.Length; i++)
            {
                txtFile +=(char) fileStream.ReadByte();
            }

            Console.WriteLine(txtFile);
            Console.ReadKey();
        }
    }
}
//while (true)
//{
//    Console.WriteLine("Enter number list:");
//    var input = Console.ReadLine();
//    var numbersSeprate = input.Split(',');
//    var numbers = new int[numbersSeprate.Length];
//    var i = 0;
//    var getch = " ";
//    foreach (var number in numbersSeprate)
//    {
//        if (!string.IsNullOrWhiteSpace(numbersSeprate[i]))
//        {
//            numbers[i] = Convert.ToInt32(number);
//            if (!(numbers[i] > 5))
//            {
//                Console.WriteLine("The number is less then 5..." + "invalid list".ToUpper());
//                Console.WriteLine("Press o to continue:");
//                getch = Console.ReadLine();
//                if (getch == "o")
//                    break;
//            }
//        }
//        else
//        {
//            Console.WriteLine("This is empty space" + "invalid list".ToUpper());
//            Console.WriteLine("Press o to continue:");
//            getch = Console.ReadLine();
//            if (getch == "o")
//                break;
//        }
//        i++;
//    }
//    if (getch == "o")
//        continue;
//    Array.Sort(numbers);
//    var length = 3;
//    for (int j = 0; j < length; j++)
//    {
//        Console.WriteLine(numbers[j]);
//    }
//    break;
//}