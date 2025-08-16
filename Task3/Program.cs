using System;
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
