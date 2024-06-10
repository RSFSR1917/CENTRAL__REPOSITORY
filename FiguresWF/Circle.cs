using System;

namespace FiguresWF
{
    ///окружность++
    internal class Circle : Figure
    {
        public double Radius { get; set; }
        int mode = 0;
        public Circle()
        {
            Radius = 0;
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Square()
        {
            mode = 0;
            return Math.PI * (Radius * Radius);
        }
        public override double Perimeter()
        {
            mode = 1;
            return 2 * Math.PI * Radius;
        }

        public override string ToString()
        {
            if (mode == 0)
            {
                return string.Format("Окружность (П x Р^2 = П x {0}^2)", Radius);
            }
            if (mode == 1)
            {
                return string.Format("Окружность (2ПР = 2 x {0} x Р)", Radius);
            }
            return string.Format("ERROR");
        }
    }
}
