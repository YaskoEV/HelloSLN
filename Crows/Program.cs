

namespace Crows
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число ворон на ветке: ");
            int crows = int.Parse(Console.ReadLine());

            string help;
            /*
            int res = crows%100;

            if (res > 10 && res < 15) help = "ворон";
            else 
            {
                switch (crows%10)
                {
                    case 1: help = "ворона"; break;
                    case 2:
                    case 3:
                    case 4: help = "вороны"; break;
                    default: help = "ворон"; break;

                }
            }
            */

            int res = crows % 100;

            help = (res > 10 && res < 15) ? "ворон" : (crows % 10) switch
                {
                    1 => "ворона",
                    >= 2 and <=4 => "вороны",
                    _ => "ворон"
                };

            //Console.WriteLine("res = {0}", res);
            Console.WriteLine("На ветке {0} {1}", crows, help);  
        }
    }
}
