using MindBox.Shapes.Abstractions;

namespace MindBox.Shapes;

public class Circle : IShape
{
    private double Radius { get; }

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Радиус круга должен быть положительным числом.", nameof(radius));
        Radius = radius;
    }

    public double GetArea() => Math.PI * Radius * Radius;
}