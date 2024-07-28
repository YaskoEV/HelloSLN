using System.Text;

namespace mod4ex2
{
    internal class Program
    {
        static string IntToBinary(int x)
        {
            int count = 0;
            int mask = 1;
            int size = 32;

            StringBuilder strX = new StringBuilder();
            StringBuilder strXRes = new StringBuilder();

            while (size > 0)
            {
                if (((mask) & x) > 0)
                {
                    strX = strX.Append("1");
                }
                else
                {
                    count++;
                    strX = strX.Append("0");
                }
                mask = mask << 1;
                size--;
            }

            for (int i = 31; i >= 0; i--)
            {
                //Console.Write(strX[i]);
                strXRes.Append(strX[i]);
                if (i == 8 || i == 16 || i == 24) 
                { 
                    //Console.Write(" ");
                    strXRes.Append(" ");
                }


            }
            //Console.WriteLine();

            return strXRes.ToString();
        }
        static void Main(string[] args)
        {
            int x = 8;
            Console.WriteLine(IntToBinary(x));
        }
    }
}
