using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Line : Shape
    {
        private double x1 {  get; set; }
        private double y1 { get; set; }
        private double x2 { get; set; }
        private double y2 { get; set; }

        public Line(double x1, double y1, double x2, double y2, string color = DEF_COLOR)
            :base(color)
        {
            this.x1 = x1;       
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public void Move(double x1, double y1, double x2, double y2)
        {
            this.x1 += x1;
            this.y1 += y1;
            this.x2 += x2;
            this.y2 += y2;
        }

        public void Scale(double scale)
        {
            x2  *= scale;
        }

        public override void Draw()
        {
            Console.WriteLine("Линия:");
            Console.WriteLine("Координаты линии\nНачало: x1 = {0}, y1 = {1}\nКонец x1 = {2}, y1 = {3}\nЦвет линии - {4}", x1, y1, x2, y2, Color);
        }

        public override string ToString()
        {
            return $"Метод ToString для класса Line:\nКоординаты линии\nНачало: x1 = {x1}, y1 = {y1}\nКонец x2 = {x2}, y2 = {y2}\nЦвет линии - {Color}";
        }
    }
}
