namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrLenght = 5;
            int[] arr = new int[5] { 1,2,3,4,5 };
            int[] arr2 = new int[arrLenght];
            //int[] arr2 = new int[arrLenght] { 1, 2, 3, 4, 5 };
            //int[] arr3 = new int[5] { 1, 2, 3, 4 };

            Console.WriteLine("arr2 lenght = {0}", arr2.Length);

            int[,] matrix =
            {
                {1,2,3},
                {4,5,6}
            };

            Console.WriteLine("matrix lenght = {0}", matrix.Length);

            foreach (int i in matrix)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write("{0, -4}", matrix[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine();

            int[] d = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Range r = 2..5;
            int[] d1 = d[r];
            int[] d2 = d[..]; // весь диапазон
            int[] d3 = d[2..^2];

            foreach (int i in d1) Console.Write("{0, -4}", i);
            Console.WriteLine();
            foreach (int i in d3) Console.Write("{0, -4}", i);
            Console.WriteLine();

            //var stackArray = stackalloc int[3] { 100, 200, 300 }; unsafe
            Span<int> span = stackalloc int[3] { 100, 200, 300 }; //массив в стэке, а не в куче
            foreach (int i in span) Console.Write("{0, 4}", i);
        }
    }
}
