using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Rectangle
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }

        public Rectangle (double side1, double side2)
        {
            this.Side1 = side1;
            this.Side2 = side2;
        }

        private double AreaCalculator()
        {
            return Side1 * Side2;
        }

        private double PerimetrCalculator()
        {
            return Side1 * 2 + Side2 * 2;
        }

        public double Area
        {
            get
            {
                return AreaCalculator();
            }
        }

        public double Perimetr
        {
            get
            {
                return PerimetrCalculator();
            }
        }

    }
}
