using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    public class Triangle : Shape
    {
        private double _c;

        public double C
        {
            get
            {
                return _c;
            }
            set
            {
                if (value > 0)
                {
                    _c = value;
                }
            }
        }

        public Triangle()
        {
            //A = 1;
            //B = 1;
            C = 1;
        }

        public static int AnglesSum => 180;

        public override double Square
        {
            get
            {
                var halfPerimetr = Perimetr / 2;
                return Math.Sqrt(
                    halfPerimetr * (halfPerimetr - A) * (halfPerimetr - B) * (halfPerimetr - C));
            }
        }

        public override double Perimetr => A + B + C;
    }
}
