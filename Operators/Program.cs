using System;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = -55;
            if (n > 0)
            {
                Console.WriteLine("n больше 0");
                Console.WriteLine("n > 0");
            }
            else
                if (n > -100) 
                Console.WriteLine("n > -100");
                else
                Console.WriteLine("n Не больше 0");

            int a = 5;
            string s;
            /*
            if (a == 0)
                s = "ноль";
            else
                s = "не ноль";
            */

            s = (a == 0) ? "ноль" : "не ноль";
            Console.WriteLine(s);

            string name = null;//"Sergey";
            /*
            if (name != null)
                Console.WriteLine(name.ToUpper());
            else
                Console.WriteLine("Пустое имя");
            */
            Console.WriteLine(name != null ? name.ToUpper() : "пустое имя");
            Console.WriteLine((name ?? "Пустое имя").ToUpper());
        }
    }
}
