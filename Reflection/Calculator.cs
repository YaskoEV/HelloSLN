using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    [Author("Sergey")]
    internal class Calculator
    {
        public int X { get; set; }
        public int Y { get; set; }

        [Label("Сложение чисел")]
        public int Add()
        {

            return X + Y;
        }

        [Label("Вычитание чисел")]
        public int Substraction() => X - Y; // равносильно Add но упрощение записи


    }
}
