using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Point : Shape
    {
        private int x {  get; set; }
        private int y { get; set; }

        public Point(int x, int y, string color = DEF_COLOR)
            :base (color)
        {
            this.x = x; 
            this.y = y;
        }

        public void Move(int x, int y)
        {
            this.x += x;
            this.y += y;
        }

        public override void Draw()
        {
            Console.WriteLine("Точка:");
            Console.WriteLine("Координаты точки: x = {0}, y = {1}, цвет {2}", x, y, Color);
        }

        public override string ToString()
        {
            return $"Метод ToString для класса Point:\nКоординаты точки: x = {x}, y = {y}, цвет {Color}";
        }

    }
}
