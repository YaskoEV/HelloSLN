using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public abstract class Shape
    {
        public const string DEF_COLOR = "black";
        public string Color {  get; set; }

        public Shape(string color = DEF_COLOR)
        {
            Color = color;
        }


        public abstract void Draw();
        /*
        public virtual void Draw()
        {
            Console.WriteLine($"Shape. {Color}");
        }
        */
    }
}
