using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    public class Rectangle : Shape
    {
        public override double Perimetr => (A + B) * 2;

        public override double Square => A * B;
    }
}
