using System.Collections.Generic;
namespace Mosh_advance_course
{
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() { Title = "hun ki hoga mera", Price =99 },
                new Book() { Title = "ay ma mer gaya", Price =1000 },
                new Book() { Title = "usama", Price =500 },
                new Book() { Title = "mangoman", Price =700 },
                new Book() { Title = "cshaarp", Price =8 }
            };
        } 
    }
}