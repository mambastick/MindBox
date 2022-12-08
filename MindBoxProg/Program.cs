using MindBoxLib;

namespace MindBoxTestProg
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Circle circle = new Circle(4);
                Triangle triangle = new Triangle(3, 4, 5);

                Console.WriteLine("Площадь круга: " + circle.CalcSquare());
                Console.WriteLine("Площадь треугольника: " + triangle.CalcSquare());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}