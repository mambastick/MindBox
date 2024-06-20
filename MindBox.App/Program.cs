using MindBox.Shapes;
using MindBox.Shapes.Abstractions;

namespace MindBox.App;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Создание экземпляра круга
            IShape circle = new Circle(5);
            Console.WriteLine($"Площадь круга с радиусом 5: {circle.GetArea()}");

            // Создание экземпляра треугольника
            ITriangle triangle = new Triangle(3, 4, 5);
            Console.WriteLine($"Площадь треугольника с сторонами 3, 4, 5: {triangle.GetArea()}");
            Console.WriteLine($"Треугольник с сторонами 3, 4, 5 является прямоугольным: {triangle.IsRightAngled}");

            // Создание не правильного треугольника
            try
            {
                ITriangle invalidTriangle = new Triangle(1, 2, 3);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка создания треугольника: {ex.Message}");
            }

            // Создание не правильного круга
            try
            {
                IShape invalidCircle = new Circle(-5);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка создания круга: {ex.Message}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}