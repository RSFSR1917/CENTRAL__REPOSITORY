using System;

namespace FiguresWF
{
    ///квадрат++
    internal class Square_ : Figure
    {
        public double Side { get; set; }
        int mode = 0;

        public Square_()
        {
            Side = 0;
        }

        public Square_(double side)
        {
            Side = side;
        }

        public override double Square()
        {
            mode = 0;
            return Side * Side;
        }

        public override double Perimeter()
        {
            mode = 1;
            return Side * 4;
        }

        public override string ToString()
        {
            if (mode == 0)
            {
                return string.Format("Квадрат (С ^ 2 = {0}^2)", Side);
            }
            if (mode == 1)
            {
                return string.Format("Квадрат (С x 4 = {0} x 4)", Side);
            }
            return string.Format("ERROR");
        }
    }
}
