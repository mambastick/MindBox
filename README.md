# MindBoxLib
Библиотека для расчёта площади различных фигур.

<h1>Задание C#</h1>

Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:

- Юнит-тесты

- Легкость добавления других фигур

- Вычисление площади фигуры без знания типа фигуры в compile-time

- Проверку на то, является ли треугольник прямоугольным

<b>Решение:</b>

[Библиотека](https://github.com/mambastick/MindBox/blob/main/MindBoxLib/SquareCalculator.cs)

Ее использование:

```c#
using MindBoxLib;

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
```
<h2>Задание SQL</h2>
В базе данных MS SQL Server есть продукты и категории. 
Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». 
Если у продукта нет категорий, то его имя все равно должно выводиться.

<b>Решение:</b>

Для начала создадим базу данных:
```SQL
CREATE DATABASE MindBox;
```

Затем три таблицы:
```SQL
CREATE TABLE `Categories` ( `id` INT(11) NOT NULL AUTO_INCREMENT , `Name` VARCHAR(30) NOT NULL , PRIMARY KEY (`id`)) ENGINE = InnoDB;
CREATE TABLE `Products` ( `id` INT(11) NOT NULL AUTO_INCREMENT , `Name` VARCHAR(30) NOT NULL , PRIMARY KEY (`id`)) ENGINE = InnoDB;
CREATE TABLE `ProductCategories` ( `CategoryID` INT NOT NULL , `ProductID` INT NOT NULL ) ENGINE = InnoDB;
```

Внесем некоторые данные, чтобы проверить работоспособность будущего запроса:
```SQL
INSERT INTO Categories
VALUES
	(1, 'Смартфон'),
	(2, 'Автомобиль'),
	(3, 'Видеокарта');

INSERT INTO Products
VALUES
	(1, 'RTX 4090'),
	(2, 'iPhone 14'),
	(3, 'VW POLO'),
	(4, 'Часы Wenger');

INSERT INTO ProductCategories 
VALUES
  (1, 2), 
  (2, 3), 
  (3, 1);

```

Ну и теперь перейдём к запросу:
```SQL
SELECT P.Name, C.Name 
FROM Products P 
LEFT JOIN ProductCategories PC ON P.Id = PC.ProductId 
LEFT JOIN Categories C ON PC.CategoryId = C.Id
```
