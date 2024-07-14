namespace LabForLesson2
{

    enum Figures 
    {
        Romb = 1, 
        Rectangle,
        Cube
    }

    struct FigData
    {
        public int width;
        public int height;
        public Figures type;
    }
    public class Program
    {
        static void Main(string[] args)
        {
            FigData rect = new FigData();
            rect.type = Figures.Rectangle;
            rect.width = 10;
            rect.height = 5;

            Console.WriteLine($"Площадь фигуры {rect.type} равна " + rect.width * rect.height + " см2");
        }
    }
}
