using System.Reflection;
using System.Text;
using System.Xml.Linq;

namespace Reflection
{
    internal class Program
    {
        ~Program() 
        {
            Console.WriteLine("GC done!"); 
        }
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            Console.WriteLine(assembly.GetTypes());

            StringBuilder sb = new StringBuilder();



            foreach (var type in assembly.GetTypes())
            {
                int count = 0;
                sb.AppendLine(type.FullName);
                foreach (var property in type.GetProperties())
                {
                    sb.Append("Name: ");
                    sb.Append(property.Name);
                    sb.Append("  Type: ");
                    sb.AppendLine(property.PropertyType.ToString());
                    //"Name: {0} - Type: {1}", property.Name, property.PropertyType);
                }

                MethodInfo[] methods = type.GetMethods();
                foreach (var method in methods)
                {
                    count++;
                    sb.Append("MethodName_" + count + ": ");
                    sb.AppendLine(method.Name);
                }

            }

            Console.WriteLine(sb.ToString());

            
            //Выполните преобразование из целого типа данных в логический тип.
            int a = 3;

            bool res = Convert.ToBoolean(a);
            Console.WriteLine(res);

            GC.Collect();
            Console.ReadLine();

            //int a = 5; int b = 5;

            //Calculator calculator = new Calculator();
            //calculator.X = a;
            //calculator.Y = b;


            //Console.WriteLine(calculator.Add());



            //Type[] types = assembly.GetTypes();
            //foreach (Type t in types)
            //{
            //    Console.WriteLine(t.FullName);
            //    PropertyInfo[] propInfo = t.GetProperties();
            //    foreach (PropertyInfo pi in propInfo)
            //    {
            //        Console.WriteLine(pi.PropertyType.Name);
            //        Console.WriteLine(pi.Name);
            //        Console.WriteLine(pi.GetType().);
            //    }




            //MethodInfo[] methodInfo = t.GetMethods();
            //foreach (MethodInfo method in methodInfo)
            //{
            //    Console.WriteLine("Тип возвращаемого значения {0} для метода {1};", method.ReturnType, method.Name);
            //    //Type typeInt = method.ReturnType;
            //    //bool res = true;
            //    //if (typeInt != null)
            //      //  Convert.ToBoolean(typeInt);

            //    //Console.WriteLine("Преобразованный тип возвращаемого значения {0} для метода {1};", typeInt, method.Name);
            //    //Console.WriteLine(method.GetParameters());
            //}
            //}

        }
        
    }
}
