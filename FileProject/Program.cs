using System.IO;
using System.Text;

namespace FileProject
{
    internal class Program
    {
        const string fileName = @"..\..\..\testFile.txt";
        static void Main(string[] args)
        {

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            FileInfo file_1 = new FileInfo(fileName);
            if (!file_1.Exists) file_1.Create();

            Console.WriteLine($"{file_1.FullName} {file_1.CreationTime}");

            foreach (FileInfo fileInfo in new DirectoryInfo(Path.Combine("..", "..", "..")).GetFiles())
                Console.WriteLine(fileInfo.Name);

            // foreach( string line in File.ReadAllLines(file_1.ToString()))
            //     Console.WriteLine(line);

            //FileStream fs = File.OpenRead(fileName);
            //new FileStream(fileName, FileMode.Open, FileAccess.Read);

            /*
            try 
            {
                int ch;
                while ((ch = fs.ReadByte()) != -1)
                    Console.Write((char)ch);
            }
            finally
            {
                fs?.Dispose();
            }
            */

            using (FileStream fs = File.OpenRead(fileName))
            {
                int ch;
                while ((ch = fs.ReadByte()) != -1)
                    Console.Write((char)ch);
            }

            Console.WriteLine();
            Console.WriteLine();

            using (StreamReader reader = new StreamReader(fileName, Encoding.GetEncoding(1251)))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            
        }
    }
}
