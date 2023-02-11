namespace FiguresArea
{
    public class Circle : Figure
    {
        public double Radius { get; set; } = 2;
        public Circle(double radius)
        {
            if (radius <= 0)
                Console.WriteLine("There is no such circle. Default radius is set (2).");
            else
            {
                Radius = radius;
            }   
        }
        public override double GetArea()
        {
            Area = Math.Round(Math.PI * Math.Pow(Radius, 2), 3);
            return Area;
        }
    }
}