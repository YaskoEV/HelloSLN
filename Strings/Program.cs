using System.Text;
using System.Text.RegularExpressions;

namespace Strings
{
    internal class Program
    {
        public override string ToString()
        {
            return "Описание: Базовая строка";
        }
        static void Main(string[] args)
        {
            string n = string.Empty;
            string s = "Sergey";

            Console.WriteLine(s = s.ToUpper());

            string[] names = new string[5];

            foreach (string name in names)
            {
                names[0] = name;
                if(name != null)
                Console.WriteLine(names[0]);
                Console.WriteLine(names[0] != null ? names[0].ToLower() : "пустая строка");
                //Console.WriteLine(names[0]?.ToLower());
            }
            Console.WriteLine();

            Program app = new Program();
            Console.WriteLine(app.ToString());

            Console.WriteLine();

            string numStr = "123";
            //int num = int.Parse(numStr);
            Console.WriteLine(numStr);

            int num;
            if (int.TryParse(numStr, out num))
            {
                Console.WriteLine(num *2);
            } else Console.WriteLine("Не числовое значение");

            Console.WriteLine(Convert.ToInt32(numStr));

            string result = string.Empty;
            //VERY BAD CODE!!!
            for (int i = 1; i <= 100; i++)
            {
                result += i.ToString() + " ";
                //Console.WriteLine(result);
            }
            //Console.Write(result);

            StringBuilder sb = new StringBuilder();
            for (int i = 1;i <= 100; i++)
            {
                //sb.Append(i.ToString() + " ");
                sb.Append(i).Append(" ");
                //Console.WriteLine(sb);
            }
            //Console.WriteLine(sb);
            result = string.Empty;
            Console.WriteLine(result);

            result = sb.ToString();
            Console.WriteLine(result);

            result = string.Empty;

            string phone = "999 999-99-99";
            Regex reg = new Regex(@"\d\d\d \d\d\d-\d\d-\d\d");
            if (reg.IsMatch(phone)) Console.WriteLine(phone);
            else Console.WriteLine("It's wrong phone formate");


        }
    }
}
