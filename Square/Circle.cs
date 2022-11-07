

namespace Square
{
    public class Circle: IGetSquare
    {
        public double Radius { get; }
        public Circle(double radius)
        {
            if(radius <= 0) throw new ArgumentException("Неверно указан радиус круга.");
            Radius = radius;
        }
        public double GetSquare()
        {
            return Radius*Radius*Math.PI;
        }
    }
}
