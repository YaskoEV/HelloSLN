namespace Geometry
{
    public class Point : Shape, IComparable<Point>
    {
        private int x { get; set; }
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

        public double Distance
        {
            get
            {
                return Math.Sqrt(x * x + y * y);
            }
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

        public Point Add(Point p)
        {
            return new Point(this.x + p.x, this.y + p.y);
        }

        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.x + p2.x, p1.y + p2.y);
        }

        public static Point operator +(Point p1, int p2)
        {
            return new Point(p1.x + p2, p1.y + p2);
        }

        public static Point operator +(int p1, Point p2)
        {
            //return new Point(p1 + p2.x, p1 + p2.y);
            return p2 + p1;
        }

        public override bool Equals(object? obj)
        {
            if(obj is Point p)
                return this.x == p.x && this.y == p.y;
            else
            return base.Equals(obj);
        }

        
        public static bool operator ==(Point p1, Point p2)
        {
            return object.Equals(p1, p2);
        }

        public static bool operator !=(Point p1, Point p2)
        {
            return !(p1 == p2);
        }

        public override int GetHashCode()
        {
            return (x,y).GetHashCode();
        }
        public int CompareTo(Point p)
        {
            if(this.Distance > p.Distance) return 1;
            if (this.Distance < p.Distance) return -1;
            return 0;
        }

        public static bool operator >(Point p1, Point p2)
        {
            return p1.CompareTo(p2) > 0;
        }
        public static bool operator <(Point p1, Point p2)
        {
            return p1.CompareTo(p2) < 0;
        }

        public static explicit operator double(Point p)
        {
            return p.Distance;
        }

        public int this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return x;
                    case 1: return y;
                    default: throw new IndexOutOfRangeException();
                }
            }
            set
            {
                switch (index)
                {
                    case 0: x = value; break;
                    case 1: y = value; break;
                    default: throw new IndexOutOfRangeException();
                }
            }
        }


    }
}
