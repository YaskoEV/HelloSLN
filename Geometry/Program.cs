using System;

namespace Geometry
{
    public enum Figures { Romb, Rect, RightTriangle, Circle }

    public struct Fdata
    {
        public int x0, y0;
        public double a, b;
        public int color;
        public Figures type;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rect rect = new Rect(new Fdata() {x0=1,y0=1,a=3,b=5});
            rect.Move(2, 1);
            rect.PrintInfo();
            Console.WriteLine(rect.Area());

            RightTriangle rt = new RightTriangle(new Fdata() { x0 = -1, y0 = -3, a = 1, b = 4 });
            rt.Move(1, 1);
            rt.PrintInfo();
            Console.WriteLine(rt.Area());

            Circle c = new Circle(0, 0, 10);
            Console.WriteLine($"Площадь круга = {c.Area()}");
            Console.WriteLine($"Длина окружности = {c.CircleLenght()}");
            c.Scale(1.5);
            Console.WriteLine($"Площадь круга = {c.Area()}");
            Console.WriteLine($"Длина окружности = {c.CircleLenght()}");
            c.Move(2, 1);
            c.Move(-5, 8);
            c.PrintInfo();


            object[] data = {rect, rt};
            Print(data);
        }

        public static void Print(object[] data)
        {

        }
    }
}
