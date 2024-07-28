﻿using System;

namespace Geometry
{
    class Romb : Shape
    {
        Fdata fd;

        public double a {
            get { return fd.a; }
            set { fd.a = value;}
        }
        public double b
        {
            get { return fd.b; }
            set { fd.b = value; }
        }
        public Romb(Fdata fd)
        {
            this.fd = fd;
            this.fd.type = Figures.Rect;
        }

        public double Area()
        {
            return a * b; 
        }
        public void Move(int dx, int dy)
        {
            fd.x0 += dx;
            fd.y0 += dy;
        }
        public override void Draw()
        {
            Console.WriteLine("Ромб:");
            Console.Write(fd.type + ":" + fd.x0 + "," + fd.y0 + " color=" + fd.color);
            Console.WriteLine(" a="+a+" b="+b);
        }
    }
}
