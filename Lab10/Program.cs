using Lab10_me;
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


            //Вариант 1
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


            //Вариант 2
            using (StreamWriter sw = new StreamWriter(Path.Combine("..", "..", "..", "booksSR.xml")))
            {
                XmlSerializer serializerSR = new XmlSerializer(books.GetType());
                serializerSR.Serialize(sw, books);
            }

            books = null;
            using (StreamReader reader = new StreamReader(Path.Combine("..", "..", "..", "booksSR.xml")))
            {
                XmlSerializer serializerSR = new XmlSerializer(typeof(Book[]));
                books = (Book[])serializerSR.Deserialize(reader);
            }
            foreach (Book book in books)
            {
                Console.WriteLine(book.ToString());
            }


            Books2 books2 = new Books2();
            //Вариант 3 сериализовать объект Books2
            using (StreamWriter sw = new StreamWriter(Path.Combine("..", "..", "..", "books2.xml")))
            {
                XmlSerializer serializerSR = new XmlSerializer(books2.GetType());
                serializerSR.Serialize(sw, books2);
            }

            books = null;
            using (StreamReader reader = new StreamReader(Path.Combine("..", "..", "..", "books2.xml")))
            {
                XmlSerializer serializerSR = new XmlSerializer(typeof(Books2));
                books2 = (Books2)serializerSR.Deserialize(reader);
            }
            foreach (Book book in books2)
            {
                Console.WriteLine(book.ToString());
            }






            Console.WriteLine("SROk");

        }
    }
}
