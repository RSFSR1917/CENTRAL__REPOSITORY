namespace FiguresWF
{
    internal abstract class Figure
    {
        public abstract double Square();
        public abstract double Perimeter();

        public virtual double Perimetr { get { return 0; } }

        public override string ToString()
        {
            return "Simple Figure";
        }
    }
}
