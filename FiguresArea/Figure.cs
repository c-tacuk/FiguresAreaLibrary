namespace FiguresArea
{
    public class Figure
    {
        public double Area { get; set; }
        public virtual double GetArea() { return Area; }
        public void DisplayArea() { Console.WriteLine("Area: " + GetArea()); } 
    }
}