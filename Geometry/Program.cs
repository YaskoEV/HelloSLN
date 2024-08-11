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
        //static double area(Fdata fd)
        //{
        //    double res = 0;
        //    //if (fd.type.GetTypeCode() == 0) s = fd.a * fd.b / 2;
        //    //switch (fd.type.ToString()) 
        //    //{
        //    //    case "Romb":  s = fd.a * fd.b / 2; break;
        //    //    case "Rect": s = fd.a * fd.b; break;
        //    //    case "RightTriangle": s = fd.a * fd.b / 2; break;
        //    //    case "Circle": s = fd.a+ fd.a * Math.PI; break;
        //    //    default: s = fd.a * fd.b / 2; break;
        //    //};
        //    res = (fd.type.ToString()) 
        //        switch
        //        {
        //            //"Romb" => s = fd.a * fd.b / 2,
        //            "Rect" => res = fd.a * fd.b,
        //            //"RightTriangle" => s = fd.a * fd.b / 2,
        //            "Circle" => res = fd.a + fd.a * Math.PI,
        //             _ => res = fd.a * fd.b / 2
        //        };

        //    return res;
        //}
        static void Main(string[] args)
        {

            
            Romb romb = new Romb(new Fdata() { x0 = 1, y0 = 1, a = 4, b = 3});
            //Console.WriteLine(romb.GetType().Name);
            //Console.WriteLine(romb.Area());
            //Console.WriteLine("Ok");

            Rect rect = new Rect(new Fdata() {x0=1,y0=1,a=3,b=5});
            //rect.Move(2, 1);
            //rect.PrintInfo();
            //Console.WriteLine(rect.Area());

            RightTriangle rt = new RightTriangle(new Fdata() { x0 = -1, y0 = -3, a = 1, b = 4 });
            //rt.Move(1, 1);
            //rt.PrintInfo();
            //Console.WriteLine(rt.Area());

            Circle c = new Circle(0, 0, 10, "green");
            Console.WriteLine($"Площадь круга = {c.Area()}");
            Console.WriteLine($"Длина окружности = {c.CircleLenght()}");
            c.Scale(1.5);
            Console.WriteLine($"Площадь круга = {c.Area()}");
            Console.WriteLine($"Длина окружности = {c.CircleLenght()}");
            Console.WriteLine();

            c.Move(2, 1);
            c.Move(-5, 8);
            c.Draw();
            

            //Shape s1 = c;

            //s1.Draw();
            ////Circle c2 = (Circle)s1;
            //Circle c2 = s1 as Circle;
            //c2.Draw();

            ////object[] data = {rect, rt};
            ////Print(data);

            Point p = new Point(2, 3, "grey");
            p.Draw();
            p.Move(2, 1);
            p.Draw();

            Console.WriteLine(c.ToString());


            Line l = new Line(0, 0, 1, 1, "pink");
            l.Move(1, 1, 1, 1);
            l.Draw();
            l.Scale(2);
            Console.WriteLine(l.ToString());

            Shape[] shapes = { romb, rect, rt, c, l };
            DrawScene(shapes);


            {
                Point p1 = new Point(10, 20);
                Point p2 = new Point(30, 10);
                Point p3 = p1.Add(p2);
                Point p4 = p3 + p2;

                Console.WriteLine();
                Console.WriteLine("Перегрузка операций");
                p1.Draw();
                p2.Draw();
                p3.Draw();
                p4.Draw();

                p4 = p3 + 5;
                Console.WriteLine("Перегрузка операций Новый p4 + справа");
                p4.Draw();

                p4 = 7 + p3;
                Console.WriteLine("Перегрузка операций Новый p4 + слева");
                p4.Draw();

                Point pp1 = new Point(1, 1);
                Point pp2 = new Point(1, 1);

                Console.WriteLine();
                Console.WriteLine("Сравнить рр1 и рр2");
                Console.WriteLine(pp1 == pp2);

                Console.WriteLine();
                Console.WriteLine("Сравнить рр1 и рр2 через Equals");
                Console.WriteLine(pp1.Equals(pp2));

                double d = (double)p1;
                Circle circle = new Circle(10, 20, 30);
                Point point = (Point)circle;

                Console.WriteLine();
                Console.WriteLine("Индексы координат перегрузка");
                Console.WriteLine(pp1[0]);
                Console.WriteLine(pp1[1]);


            }

        }

        public static void DrawScene(Shape[] shapes)
        {
            Console.WriteLine();
            Console.WriteLine("Старт метода DrawScene");
            int i = 0;
            foreach (Shape shape in shapes) 
            {
                i++;
                Console.WriteLine();
                Console.Write($"{i}: ");
                shape.Draw();
            }
        }

        

        //public static void Print(object[] data)
        //{

        //}
    }
}
