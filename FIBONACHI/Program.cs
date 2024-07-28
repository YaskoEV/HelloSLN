namespace FIBONACHI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1;
            int f;
            Console.Write("{0, -5}", a);
            Console.Write("{0, -5}", b);


            while ((f = a+b) < 1000)
            {
                Console.Write("{0, -5}", f);
                a = b;
                b = f;
            };


        }
    }
}
