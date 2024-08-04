using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    internal class Calculator
    {
        public int X { get; set; }
        public int Y { get; set; }

        public int Add()
        {

            return X + Y;
        }

        public int Substraction() => X - Y; // равносильно Add но упрощение записи


    }
}
