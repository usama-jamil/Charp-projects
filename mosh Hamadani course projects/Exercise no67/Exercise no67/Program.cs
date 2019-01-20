using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_no67
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "4-5-7-8-2-3";
            var otherList = new List<int>();

            var numbers = new List<int>() { 3, 4, 6, 7, 7, 64, 3, 9, 9, 9 };
            var duplicateList = new List<int>(UniqueInList(numbers));
            

                foreach (var duplicate in duplicateList)
                {
                    Console.WriteLine(duplicate);                    
                }
            Console.ReadKey();
        }
        public static List<int> UniqueInList(List<int> numbers)
        {
            var uniqueList = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 0; j < numbers.Count; j++)
                {
                    if (numbers[i] == numbers[j] && !uniqueList.Contains(numbers[i]))
                    {

                        uniqueList.Add(numbers[i]);
                    }
                }
            }

            return uniqueList;
        }
        public static List<int> DuplicateInList(List<int> numbers)
        {
            var duplicateList = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 0; j < numbers.Count; j++)
                {
                    if (i == j)
                        continue;
                    if (numbers[i] == numbers[j] && !duplicateList.Contains(numbers[i]))
                    {

                        duplicateList.Add(numbers[i]);
                    }
                }
            }

            return duplicateList;
        }
        public static int VowelsInWord(string word)
        {
                 word = word
                       .Trim()
                       .ToLower();
            int vowels = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u')
                {
                    vowels++;
                }
            }
            return vowels;
        }
        public static string GetVariableName(string input)
        {
            var splitInput = input.Split(' ');
            var variable = "";
            var length = splitInput.Length;
            for (int i = 0; i < length; i++)
            {
                var rawWord = splitInput[i];
                var firstLetter = rawWord.Substring(0, 1);
                var otherLetter = rawWord.Substring(1);
                var word = firstLetter.ToUpper() + otherLetter.ToLower();
                variable += word;

            }
            return variable;
        }
        public static bool IsTimeValid(string time)
        {
        var tempTime  = time.Split(':');
            var hour = Convert.ToInt32(tempTime[0]);
            var min = Convert.ToInt32( tempTime[1]);
            if ((hour >= 0 && hour <= 23) && (min >= 00 && min <= 59))
            {
                return true;
            }
            else
            {
                return false;
            }
         }
        public static string ReverseName(string name)
        {
            var reverse = new char[name.Length];

            for (int i = 0, length = name.Length - 1; i < name.Length; i++, length--)
            {
                reverse[i] = name[length];
            }
            var  reverseName = new string(reverse);
            return reverseName;
        }
    }
}
