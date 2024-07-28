using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Circle
    {
        public int x { get; set; }
        public int y { get; set; }
        private double radius { get; set; }

        public double checkR
        {
            get { return radius; }
            set { if(value > 0)
                    radius = value;
                  else 
                    throw new ArgumentException("Неверный радиус -  меньше или равен 0");
                        
                }
        }

        public Circle(int x, int y, double r) 
        {
            this.x = x;
            this.y = y;
            this.checkR = r;
        }

        //метод для вычисления площади круга
        public double Area()
        {
            //Console.WriteLine("Радиус = {0}", checkR);
            return Math.PI*Math.Pow(checkR, 2);
        }

        //метод для вычисления длины окружности
        public double CircleLenght()
        {
            return 2*Math.PI*checkR;
        }

        //метод изменения радиуса окружности
        public void Scale(double scale) 
        {
            checkR = checkR * scale;
        }

        public void Move(int x, int y) 
        {
            this.x += x;
            this.y += y;
            //Console.WriteLine("Внимание! Координаты фигуры изменились!\nНовые кооррдинаты центра: x = {0}, y = {1}", x, y);
        }

        public void PrintInfo()
        { 
            Console.WriteLine("Координаты центра окружности: x = {0}, y = {1}\nРадиус окружности = {2}", x, y, checkR); 
        }
    }
}
