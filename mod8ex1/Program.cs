using System;
using System.Numerics;

namespace mod8ex1
{
    internal class Program
    {

        public static bool factorial(uint n, out long fac)
        {
            fac = 1;
            try
            {
                for (int i = 1; i <= n; ++i)
                {
                    fac *= i;
                    if ((fac) >= Int64.MaxValue || (fac) < 1)
                    {
                        throw new Exception("Переполнение");
                    }
                    //Console.WriteLine("Факториал {0} равен {1}", i, fac);
                }
                return true;
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.ToString());
                return false;
            }
        }

        public static BigInteger factorialMatch(uint n)
        {
            long fac = 1;
            try
            {
                for (int i = 1; i <= n; ++i)
                {
                    fac *= i;
                    if ((fac) >= Int64.MaxValue || (fac) < 1)
                    {
                        throw new Exception("Переполнение");
                    }
                    //Console.WriteLine("Факториал {0} равен {1}", i, fac);
                }
                Console.Write("Факториал {0} равен: ", n);
                return fac;
            }
            catch (Exception e)
            {
                Console.Write("Переполнение. Программа завершилась с кодом: ");
                return -1;
            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine(factorial(25, out long number));
            Console.WriteLine(factorialMatch(24));
        }
    }
}
