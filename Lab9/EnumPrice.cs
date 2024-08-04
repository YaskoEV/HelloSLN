using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Lab9
{
    public class EnumPrice : IEnumerable, IEnumerator 
    {
        public int i = -1;
        Book[] data;
        internal EnumPrice(Book[] books)
        {
            data = (Book[])books.Clone();
            Array.Sort(data, Book.ByPrice());
        }

        public object Current => data[i];

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            i++;
            if (i < data.Length) return true;
            else return false;

        }

        public void Reset()
        {
            i = -1;
        }
    }


}
