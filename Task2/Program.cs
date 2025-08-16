using System;
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
