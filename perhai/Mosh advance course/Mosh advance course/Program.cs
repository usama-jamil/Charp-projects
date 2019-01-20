using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh_advance_course
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            var book = books.SingleOrDefault(b => b.Title == "usama");

            Console.WriteLine(book.Title+" "+book.Price);

            Console.ReadKey();
        }
    }
}
