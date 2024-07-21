using System;
using System.ComponentModel;

namespace Operators
{
    internal class Program
    {
        static string num(int a)
        {
            switch (a)
            {
                case -1:
                case 1: return "один";
                case 2: return "два";
                case 3: return "три";
                default: return "много";
            }
        }

        static string num2(int a) => a switch
        {
            -1 or 1 => "один",
            2 => "два",
            3 => "три",
            _ => "много"
        };
        

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

            a = 2;
            switch (a)
            {
                case -1:
                case 1:
                    Console.WriteLine("один");
                    break;
                case 2:
                    Console.WriteLine("два");
                    break;
                case 3:
                    Console.WriteLine("три");
                    break;
                default:
                    Console.WriteLine("много");
                    break;
            }

            object obj = "Innocentiy";

            switch (obj)
            {
                case int i when i < 5: Console.WriteLine("o < 5"); break;
                case int i: Console.WriteLine("o type = int"); break;
                case double i: Console.WriteLine("o type = double"); break;
                default: Console.WriteLine("?????"); break;
            }

            //switch (a)
            //{
            //    -1 or 1 => "один",
            //    2 => "два",
            //    3 => "три",
            //    _ => "много"
            //};

            Console.Write("Введите число ворон на ветке: ");
            n = int.Parse(Console.ReadLine());


        }
    }
}
