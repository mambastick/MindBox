# 📏 MindBox.Shapes

Библиотека на C# для вычисления площади фигур и определения свойств треугольников. Поддерживает круги и треугольники. 

## 📚 Оглавление

- [Описание](#описание)
- [Установка](#установка)
- [Использование](#использование)
- [Тестирование](#тестирование)
- [Примеры](#примеры)
- [Лицензия](#лицензия)

## 📖 Описание

Эта библиотека предоставляет:
- Вычисление площади круга по радиусу.
- Вычисление площади треугольника по трём сторонам (используя формулу Герона).
- Проверка, является ли треугольник прямоугольным.

Кроме того, библиотека поддерживает легко добавление других фигур.

## 🔧 Установка

Склонируйте репозиторий и соберите проект:

```bash
git clone https://github.com/ваш_репозиторий/MindBox.Shapes.git
cd MindBox.Shapes
dotnet build
```

## 🚀 Использование

Пример использования библиотеки:

```csharp
using MindBox.Shapes;
using MindBox.Shapes.Abstractions;

class Program
{
    static void Main(string[] args)
    {
        // Создание экземпляра круга
        IShape circle = new Circle(5);
        Console.WriteLine($"Площадь круга с радиусом 5: {circle.GetArea()}");

        // Создание экземпляра треугольника
        ITriangle triangle = new Triangle(3, 4, 5);
        Console.WriteLine($"Площадь треугольника с сторонами 3, 4, 5: {triangle.GetArea()}");
        Console.WriteLine($"Треугольник с сторонами 3, 4, 5 является прямоугольным: {triangle.IsRightAngled}");
    }
}
```

## 🧪 Тестирование

Для запуска юнит-тестов используйте NUnit:

```bash
cd MindBox.Tests
dotnet test
```

## 📊 Добавление новых фигур

Для добавления новой фигуры:
1. Реализуйте интерфейс `IShape`.
2. Реализуйте метод `GetArea()` для вычисления площади фигуры.

Пример для квадрата:

```csharp
using MindBox.Shapes.Abstractions;

public class Square : IShape
{
    private double Side { get; }

    public Square(double side)
    {
        if (side <= 0)
            throw new ArgumentException("Сторона квадрата должна быть положительным числом.", nameof(side));
        Side = side;
    }

    public double GetArea() => Side * Side;
}
```

## 📜 Лицензия

Этот проект лицензирован под MIT License.
