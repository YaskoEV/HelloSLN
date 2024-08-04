using System;
using System.IO;
using System.Xml.Serialization;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Book []books = Books.TestBooks;

            // Сериализация books
            XmlSerializer serializer = new XmlSerializer(books.GetType()); 

           
            using (FileStream fs = new FileStream(@"..\..\..\books.xml", FileMode.OpenOrCreate))
            {
                    serializer.Serialize(fs, books);
                    Console.WriteLine("Object has been serialized");
            }
            Console.WriteLine("Ok");


            // десериализуем объект
            XmlSerializer delSerializer = new XmlSerializer(books.GetType());
            
            using (FileStream fs = new FileStream(@"..\..\..\books.xml", FileMode.OpenOrCreate))
            {             
                books = delSerializer.Deserialize(fs) as Book[];
                    //Console.WriteLine(books.GetType());            
            }
            foreach (Book book in books)
            {
                Console.WriteLine(book.ToString());
            }

        }
    }
}
