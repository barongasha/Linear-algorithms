using System;
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
