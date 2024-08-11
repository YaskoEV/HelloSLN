namespace Generics
{
    class ReadOnlyStorage<T>
        where T : IComparable<T>
    {
        public bool IsGreater(T x)
        {
            return Data.CompareTo(x) > 0;
        }
        public T Data { get; init; }

        public ReadOnlyStorage(T data)
        {
            Data = data;
        }
    }


        internal class Program
    {
        static void Main(string[] args)
        {
            static bool IsGreater<T>(T a, T b)
                where T : IComparable<T>
            {
                return a.CompareTo(b) > 0;
            }

            Console.WriteLine(IsGreater(2, 2.2));
            Console.WriteLine(IsGreater("2.3", "2.2"));

            static void Swap<T>(ref T a, ref T b)
            {
                T c = a;
                a = b;
                b = c;
            }

            ReadOnlyStorage<int> r1 = new ReadOnlyStorage<int>(1);
            ReadOnlyStorage<double> r2 = new ReadOnlyStorage<double>(1.345);
            ReadOnlyStorage<string> r3 = new ReadOnlyStorage<string>("generic");


            Console.WriteLine(r1.Data * 5);
            Console.WriteLine(r2.Data);
            Console.WriteLine(r3.Data);
            Console.WriteLine(r2.IsGreater(0.2));

        }
    }
}
