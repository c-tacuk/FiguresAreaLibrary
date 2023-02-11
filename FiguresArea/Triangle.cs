namespace FiguresArea
{
    public class Triangle : Figure
    {
        public double FirstSide { get; set; } = 3;
        public double SecondSide { get; set; } = 4;
        public double ThirdSide { get; set; } = 5;
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if(firstSide + secondSide < thirdSide || firstSide + thirdSide < secondSide || secondSide + thirdSide < firstSide)
                Console.WriteLine("There is no such triangle. Default sides are set (3, 4, 5).");
            else if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
                Console.WriteLine("There is no such triangle. Default sides are set (3, 4, 5).");
            else
            {
                FirstSide = firstSide;
                SecondSide = secondSide;
                ThirdSide = thirdSide;
            }
            Console.WriteLine("Triangle created");
        }

        public override double GetArea()
        {
            double p = (FirstSide + SecondSide + ThirdSide) / 2;
            Area = Math.Round(Math.Sqrt(p * (p - FirstSide) * (p - SecondSide) * (p - ThirdSide)), 3);
            return Area;
        }
        public bool IsRectangular()
        {
            if (Math.Pow(FirstSide, 2) + Math.Pow(SecondSide, 2) == ThirdSide) return true;
            if (Math.Pow(FirstSide, 2) + Math.Pow(ThirdSide, 2) == SecondSide) return true;
            if (Math.Pow(SecondSide, 2) + Math.Pow(ThirdSide, 2) == FirstSide) return true;
            return false;
        }
    }
}