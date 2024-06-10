using System;

namespace FiguresWF
{
    ///трапеция++
    internal class Trapeze : Figure
    {
        public double Side_A { get; set; }
        public double Side_B { get; set; }
        public double Side_C { get; set; }
        public double Side_D { get; set; }
        double P = 0;
        int mode = 0;
        public Trapeze()
        {
            Side_A = Side_B = Side_C = Side_D = 0;
        }

        public Trapeze(double side_A, double side_B, double side_C, double side_D)
        {
            Side_A = side_A;
            Side_B = side_B;
            Side_C = side_C;
            Side_D = side_D;
        }

        public override double Square()
        {
            mode = 0;
            P = (Side_A + Side_B + Side_C + Side_D) / 2;
            return ((Side_A + Side_B) / (Math.Abs(Side_A - Side_B)) * Math.Sqrt((P - Side_A) * (P - Side_B) * (P - Side_A - Side_C) * (P - Side_A - Side_D)));
        }

        public override double Perimeter()
        {
            mode = 1;
            return Side_A + Side_B + Side_C + Side_D;
        }

        public override string ToString()
        {
            if (mode == 0)
            {
                return string.Format("Трапеция ( (С_A + C_B) / (|C_A - C_B|) x √((P - С_A)(P - С_B)(P - C_A - C_C)(P - C_A - C_D)) = ({1} + {2}) / (|{1} - {2}|) x √(({0} - {1})({0} - {2})({0} - {1} - {3})({0} - {1} - {4})) )", P, Side_A, Side_B, Side_C, Side_D);
            }
            if (mode == 1)
            {
                return string.Format("Трапеция (C_A + C_B + C_C + C_D = {0} + {1} + {2} + {3}) )", Side_A, Side_B, Side_C, Side_D);
            }
            return string.Format("ERROR");
        }
    }
}
