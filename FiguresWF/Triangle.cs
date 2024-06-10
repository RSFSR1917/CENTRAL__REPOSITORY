using System;

namespace FiguresWF
{
    ///треугольник++
    internal class Triangle : Figure
    {
        public double Side_A { get; set; }
        public double Side_B { get; set; }
        public double Side_C { get; set; }
        double P = 0;
        int mode = 0;

        public Triangle()
        {
            Side_A = Side_B = Side_C = 0;
        }

        public Triangle(double side_A, double side_B, double side_C)
        {
            Side_A = side_A;
            Side_B = side_B;
            Side_C = side_C;
        }

        public override double Square()
        {
            mode = 0;
            P = (Side_A + Side_B + Side_C) / 2;
            return Math.Sqrt(P * (P - Side_A) * (P - Side_B) * (P - Side_C));
        }

        public override double Perimeter()
        {
            mode = 1;
            return Side_A + Side_B + Side_C;
        }

        public override string ToString()
        {
            if (mode == 0)
            {
                return string.Format("Треугольник ( √(P x (P - С_A)(P - С_B)(P - C_C)) = √({0} x ({0} - {1})({0} - {2})({0} - {3})) )", P, Side_A, Side_B, Side_C);
            }
            if (mode == 1)
            {
                return string.Format("Треугольник (C_A + C_B + C_C = {0} + {1} + {2}) )", Side_A, Side_B, Side_C);
            }
            return string.Format("ERROR");
        }
    }
}