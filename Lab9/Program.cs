using System;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Books books = new Books();

            Console.WriteLine("Сортировка по цене GetByPrice");
            foreach (Book book in books.GetByPrice())       Console.WriteLine(book);
            Console.WriteLine("Сортировка по Id в обратном порядке GetReverseEnum");
            foreach (Book book in books.GetReverseEnum())   Console.WriteLine(book);
            Console.WriteLine("Сортировка по автору");
            foreach (Book book in books.GetByAuthor())      Console.WriteLine(book);

            Console.WriteLine("Список книг Books:");
            foreach (Book book in books)   Console.WriteLine(book);
        }
    }
}
