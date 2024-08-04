using System.Diagnostics;

namespace ExeptionProject
{
    internal class Program
    {

        static void Divide(string s1, string s2)
        {
            try
            {
                int n1 = int.Parse(s1);
                int n2 = int.Parse(s2);

                if (n1 < 0 || n1 > 100)
                    throw new ArgumentOutOfRangeException("n1  выходит за пределы диапазона [0...100]");

                int n = n1 / n2;

                Console.WriteLine(n);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            Console.WriteLine("Продолжение Divide");
        }
        static void Main(string[] args)
        {
            try
            {
                Divide("125", "0");
            }
            catch (DivideByZeroException e) when (e.Message != null)
            {
                Console.WriteLine(e.Message);
                //Console.WriteLine(e.ToString());
                //Debug.WriteLine(e);
                //Trace.WriteLine(e);

            }
            finally
            {
                Console.WriteLine("Finally block"); 
            }

            Console.WriteLine("Продолжение Main");
        }
    }
}
