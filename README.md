# Линейные алгоритмы

Задание 1: Дана длина L окружности. Найти ее радиус R и площадь S круга, ограниченного этой окружностью.

```
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Зададим длину L окружности. После найдём ее радиус R и площадь S круга, ограниченного этой окружностью.");
            Console.Write("Введите длину окружности L: ");
            double circumference = Convert.ToDouble(Console.ReadLine());

            double circleRadius = circumference / (2 * Math.PI); // находим радиус по формуле
            double areaOfACircle = Math.PI * Math.Pow(circleRadius, 2); // находим площадь по формуле

            Console.WriteLine("Исходя из предоставленных Вами данных, радиус круга составляет {0}, а площадь составляет {1}", Math.Round(circleRadius, 4), Math.Round(areaOfACircle, 4));
            Console.Write("Нажмите любую клавишу для завершения работы программы.");
            Console.ReadKey();
        }
    }
}
```
____
Задание 2: Даны координаты двух противоположных вершин прямоугольника: (x1, y1), (x2, y2). Стороны прямоугольника параллельны осям координат. Найти периметр и площадь данного прямоугольника.
```
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Зададим координаты двух противоположных вершин прямоугольника: (x1, y1), (x2, y2). Стороны прямоугольника параллельны осям координат. Найдём периметр и площадь данного прямоугольника.");

            #region Задаем переменные
            Console.Write("Задайте значение для x1: ");
            double x1Value = Convert.ToDouble(Console.ReadLine());

            Console.Write("Задайте значение для y1: ");
            double y1Value = Convert.ToDouble(Console.ReadLine());

            Console.Write("Задайте значение для x2: ");
            double x2Value = Convert.ToDouble(Console.ReadLine());

            Console.Write("Задайте значение для y2: ");
            double y2Value = Convert.ToDouble(Console.ReadLine());
            #endregion

            #region Находим периметр и площадь для прямоугольника
            // находим длину по оси X (ширина) и Y (высота)
            double rectangleWidth = Math.Abs(x2Value - x1Value);
            double rectangleHeight = Math.Abs(y2Value - y1Value);

            double rectanglePerimeter = 2 * (rectangleWidth + rectangleHeight);

            double areaOfRectangle = rectangleWidth * rectangleHeight;
            #endregion

            Console.WriteLine("Исходя из ваших данных, периметр прямоугольника составляет {0}, а площадь составляет {1}.", Math.Round(rectanglePerimeter, 4), Math.Round(areaOfRectangle, 4));
            Console.Write("Для завершения работы программы нажмите любую клавишу на клавиатуре.");
            Console.ReadKey();
        }
    }
}
```
___
Задание 3: Даны координаты трех вершин треугольника: (x1, y1), (x2, y2), (x3, y3). Найти его периметр и площадь, используя формулу для расстояния между двумя точками на плоскости. Для нахождения площади треугольника со сторонами a, b, c использовать формулу Герона: S = √(p(p-a)(p-b)(p-c)),  где p = a + b + c / 2 — полупериметр.
```
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Зададим координаты трех вершин треугольника: (x1, y1), (x2, y2), (x3, y3). Найдём его периметр и площадь, используя формулу для расстояния между двумя точками на плоскости.");

            #region Задаем переменные
            Console.Write("Введите значение для x1: ");
            double x1Value = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение для y1: ");
            double y1Value = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение для x2: ");
            double x2Value = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение для y2: ");
            double y2Value = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение для x3: ");
            double x3Value = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение для y3: ");
            double y3Value = Convert.ToDouble(Console.ReadLine());
            #endregion

            #region Находим периметр и площадь треугольника
            // Находим длины сторон
            double aSide = Math.Sqrt(Math.Pow(x2Value - x1Value, 2) + Math.Pow(y2Value - y1Value, 2));
            double bSide = Math.Sqrt(Math.Pow(x3Value - x2Value, 2) + Math.Pow(y3Value - y2Value, 2));
            double cSide = Math.Sqrt(Math.Pow(x1Value - x3Value, 2) + Math.Pow(y1Value - y3Value, 2));

            double perimeterOfTriangle = aSide + bSide + cSide;

            double semiperimeter = perimeterOfTriangle / 2;

            double areaOfTriangle = Math.Sqrt(semiperimeter * (semiperimeter - aSide) * (semiperimeter - bSide) * (semiperimeter - cSide));
            #endregion

            Console.WriteLine("Исходя из предоставленных Вами данных, периметр треугольника составляет {0}, а площадь по формуле Герона составляет {1}", Math.Round(perimeterOfTriangle, 3), Math.Round(areaOfTriangle, 3));
            Console.Write("Для завершения программы нажмите любую клавишу на клавиатуре.");
            Console.ReadKey();
        }
    }
}
```
