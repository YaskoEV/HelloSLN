using System.Numerics;
using System.Text;

namespace Vars
{
    enum FileMode : byte { Read = 1, Write = 100, ReadWrite = 200}
    internal class Program
    {
        static int a;

        static bool B()
        {
            Console.WriteLine("B()");
            return false;
        }

        static void Print(dynamic person)
        {
            Console.WriteLine($"{person.Name} : {person.Age}");
        }
        static void Main(string[] args)
        {
            {
                int b, c, d;
                b = 34;
                int counter;
                counter = 123;
                counter = b + 2;
                string s = "Sergey";
                Console.WriteLine(s.ToUpper());
                Console.WriteLine(s[0]);

                Console.WriteLine(counter);
                Console.WriteLine(a);
            }
            {
                bool a = false;
                bool b = false;

                bool c = a && !B();

                Console.WriteLine(c);
            }

            {
                int number;
                string s = null;
                int k = 0;
                int? kq = null;

                //if (kq == null)
                //    kq = 6;
                kq ??= 6;

                //if (kq == null)
                //    number = 0;
                //else 
                //    number = kq.Value;
                number = kq ?? 0;

                BigInteger r = BigInteger.Pow(new BigInteger(int.MaxValue), 10);
                Console.WriteLine(r);
            }
            {
                FileMode fm = FileMode.Write;
                Console.WriteLine(sizeof(FileMode));
                Console.WriteLine(sizeof(int));
                int k = (int)fm;
                Console.WriteLine(k);
            }
            {
                dynamic d = "Sergey";
                //d.ToUpper();

                var person = new { Name = "Sergey", Age = 46 };
                //Console.WriteLine($"{person.Name} : {person.Age}");
                Print(person);
            }
            {
                Type excelAppType = Type.GetTypeFromProgID("Excel.Application");
                dynamic excel = Activator.CreateInstance(excelAppType);

                excel.Visible = true;
                excel.Workbooks.Add();

            }

            {
                //string text = """<element attr="content">
                //                   <body>
                //                   </body>
                //                   </element>
                //                   """;
            }

        }
    }
}
