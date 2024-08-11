using Lab10;
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_me
{
    public class Books2 : IEnumerable<Book>
    {
        private Book[] books;
        public Books2() { this.books = Books.TestBooks; }

        public IEnumerator<Book> GetEnumerator()
        {
            return((IEnumerable<Book>)books).GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator() 
        {
            return books.GetEnumerator();
        }

        public void Add(Book book)
        {

        }
    }
}
