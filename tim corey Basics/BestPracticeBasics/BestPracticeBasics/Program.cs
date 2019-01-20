using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPracticeBasics
{
    class Program
    {
        public static string name { get; set; }
        public static string lastName { get; set; }

        static void Main(string[] args)
        {
            Console.WriteLine(PersonShow());

            Console.ReadKey();
        }


       /// <summary>
       /// this function join the firstname and lastname
       /// very well manner
       /// </summary>
       /// <returns>
       /// after joinning it return fullname of user
       /// </returns>
        private static StringBuilder PersonShow()
        {
            name = "usama";
            lastName = " jamil";

            var nameBuilder = new StringBuilder();

              return  nameBuilder.Append(name)
                        .AppendLine(lastName);
        }
    }
}
