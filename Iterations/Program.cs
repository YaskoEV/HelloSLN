namespace Iterations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.Write("{0, 5}", i * j);

            //    }
            //    Console.WriteLine();
            //}
            //string[] names = { "Елена", "Алина", "Дарья" };

            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}

            //foreach(var item in names) Console.WriteLine(item);

            IList<string> names = new List<string>() { "Елена", "Алина", "Дарья" };
            names.Insert(3, "Polina");
            names.Add("Ольга");

            IEnumerator<string> enumerator = names.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }



        }

    }
}
