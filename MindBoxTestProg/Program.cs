using MindBoxLib;

namespace MainProg
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Circle circle = new Circle(5);
                Triangle triangle = new Triangle(3, 4, 5);

                Console.WriteLine("Площадь круга: " + circle.CalcSquare());
                Console.WriteLine("Площадь треугольника: " + triangle.CalcSquare());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}