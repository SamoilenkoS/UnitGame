using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    public abstract class Shape
    {
        private double _a;
        private double _b;

        public double A
        {
            get
            {
                return _a;
            }
            set
            {
                if (value > 0)
                {
                    _a = value;
                }
            }
        }

        public double B
        {
            get
            {
                return _b;
            }
            set
            {
                if (value > 0)
                {
                    _b = value;
                }
            }
        }

        public abstract double Perimetr { get; }
        public abstract double Square { get; }

        public Shape()
        {
            A = 1;
            B = 1;
        }
    }
}
