using MindBox.Shapes;
using NUnit.Framework;
using System;

namespace MindBox.Tests
{
    [TestFixture]
    public class ShapeTests
    {
        [Test]
        public void Circle_Area_Test()
        {
            // создаем экземпляр круга с радиусом 5
            var circle = new Circle(5);

            // вычисляем площадь круга
            var actualArea = circle.GetArea();
            var expectedArea = Math.PI * 25; // Ожидаемая площадь: π * радиус²

            // сравниваем рассчитанную площадь с ожидаемой
            Assert.That(actualArea, Is.EqualTo(expectedArea).Within(1e-10));
        }

        [Test]
        public void Triangle_Area_Test()
        {
            // создаем экземпляр треугольника со сторонами 3, 4, 5
            var triangle = new Triangle(3, 4, 5);

            // вычисляем площадь треугольника
            var actualArea = triangle.GetArea();
            var expectedArea = 6; // Ожидаемая площадь для прямоугольного треугольника: 0.5 * основание * высота

            // сравниваем рассчитанную площадь с ожидаемой
            Assert.That(actualArea, Is.EqualTo(expectedArea).Within(1e-10));
        }

        [Test]
        public void Triangle_Is_RightAngled_Test()
        {
            // создаем экземпляр треугольника со сторонами 3, 4, 5
            var triangle = new Triangle(3, 4, 5);

            // является ли треугольник прямоугольным
            Assert.That(triangle.IsRightAngled, Is.True);
        }

        [Test]
        public void Invalid_Circle_Radius_Test()
        {
            // выбрасывается ли исключение при создании круга с отрицательным радиусом
            Assert.Throws<ArgumentException>(() => new Circle(-5));
        }

        [Test]
        public void Invalid_Triangle_Sides_Test()
        {
            // выбрасывается ли исключение при создании треугольника с невалидными сторонами
            Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 3));
        }
    }
}