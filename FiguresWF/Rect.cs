namespace FiguresWF
{
    ///прямоугольник++
    internal class Rect : Figure
    {
        public double Length { get; set; }
        public double Width { get; set; }
        int mode = 0;
        public Rect()
        {
            Length = Width = 0;
        }

        public Rect(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override double Square()
        {
            mode = 0;
            return Length * Width;
        }
        public override double Perimeter()
        {
            mode = 1;
            return (Length + Width) * 2;
        }

        public override string ToString()
        {
            if (mode == 0)
            {
                return string.Format("Прямоугольник (Д х Ш = {0} x {1})", Length, Width);
            }
            if (mode == 1)
            {
                return string.Format("Прямоугольник ((Д + Ш) х 2 = ({0} + {1}) x 2)", Length, Width);
            }
            return string.Format("ERROR");
        }
    }
}
