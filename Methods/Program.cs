using DoublePair = (double, double);

namespace Methods
{
    internal class Program
    {

        public static void SayHello(string name = "ХЗ кто", int age = 18)
        {
            Console.WriteLine($"Привет {name} - {age}"); 
        }

        public static void SayHello()
        {
            Console.WriteLine($"Привет!");
        }

        static void Test1(int a)
        {
            a++;
            Console.WriteLine($"Test1 a = {a}");
        }

        static void Test2(ref int a)
        {
            a++;
            Console.WriteLine($"Test2 a = {a}");
        }
        static void Test3(out int a)
        {
            a = 22;
            Console.WriteLine($"Test3 a = {a}");
        }

        static void Test4(in int a)
        {
            Console.WriteLine($"Test4 a = {a}");
        }

        static double Average(int a, int b)
        {
            double avg = (a + b) / 2d;
            return avg;
        }

        static (double, double) SinCos(double a, double b)
        {
            double h = Math.Sqrt(a * a + b * b);
            double cos = a / h;
            double sin = b / h;
            return (cos, sin);
        }
        static double Average(params int[] a)
        {
            long sum = 0L;
            foreach (int i in a)
                sum += i;   
            return (double)sum/a.Length;
        }

        static void Main(string[] args)
        {

            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine(Average(arr));
            Console.WriteLine(Average(new int[] { 1, 2, 3, 4, 5, 37 }));
            Console.WriteLine(Average( 1, 2, 3, 4, 5, 6 ));


            Console.WriteLine(SinCos(44, 2));
            var r = SinCos(4, 4);
            DoublePair r2 = SinCos(1, 1);
            Console.WriteLine(r2);
            Console.WriteLine(r2.Item1);
            Console.WriteLine(r.Item2);
            var cos = r2.Item2;
            Console.WriteLine(cos.GetType());
            Console.WriteLine(r.GetType());

            Console.WriteLine(Average(3, 4));

            {
                int a = 10;
                Test1(a);
                Console.WriteLine($"Main1 a = {a}");
            }
            {
                int a = 10;
                Test2(ref a);
                Console.WriteLine($"Main2 a = {a}");
            }
            {
                int a;
                Test3(out a);
                Console.WriteLine($"Main3 a = {a}");
                Test4(a);
                Console.WriteLine($"Main4 a = {a}");
            }


            //SayHello("Вася", 34);
            //SayHello();

        }
    }
}
