using System.Diagnostics;

namespace mod4ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            args = new string[5];
            Console.WriteLine("Необходимо ввести {0} элементов", args.Length);
            for (int i = 0; i < args.Length; i++)
            {
                Console.Write("Введите элемент номер {0} и нажмите Enter: ", i+1);
                args[i] = Console.ReadLine();
                Console.WriteLine("Вы ввели {0}", args[i]);
            }
                
            Console.Write("Параметры: ");
            for (int i = 0; i < args.Length; i++)
            {               
                if(i < args.Length -1) Console.Write("{0}, ", args[i]);
                else Console.Write("{0}", args[i]);         
            }
            Console.WriteLine();

            int result = 0;
            foreach (string arg in args)
            {
                int num;
                if (int.TryParse(arg, out num))
                {
                    result += int.Parse(arg);
                }
            }
            Console.WriteLine("Сумма числовых параметров = {0}", result);

            Console.ReadLine();
        }
    }
}
