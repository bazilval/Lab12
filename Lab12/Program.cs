using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Разработать статический класс для работы с окружностью. Класс должен содержать 3 метода:

метод, определяющий длину окружности по заданному радиусу;
метод, определяющий площадь круга по заданному радиусу;
метод, проверяющий принадлежность точки с координатами (x,y) кругу с радиусом r и координатами центра x0, y0.*/
namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = DoubleInput("Введите радиус круга: ");
            double l = Circle.Len(r);
            double s = Circle.Square(r);

            Console.WriteLine($"Длина окружности круга = {l:f3}.");
            Console.WriteLine($"Площадь круга = {s:f3}.");
            Console.WriteLine();

            double x = DoubleInput("Введите X точки: ");
            double y = DoubleInput("Введите Y точки: ");

            bool isInside = Circle.IsInside(r, x, y);
            string result = (isInside) ? "внутри" : "снаружи";
            Console.WriteLine($"Точка ({x}:{y}) {result} круга.");

            PressToExit();
        }
        static double DoubleInput(string text)
        {
            try
            {
                Console.Write(text);
                return Double.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return DoubleInput(text);
            }
        }
        static void PressToExit()
        {
            Console.WriteLine("\nНажмите любую клавишу для выхода.");
            Console.ReadKey();
        }
    }
    static class Circle
    {
        public static double Len(double radius)
        {
            return 2 * Math.PI * radius;
        }
        public static double Square(double radius)
        {
            return Math.PI * radius * radius;
        }
        public static bool IsInside(double radius, double x, double y)
        {
            double l = Math.Sqrt(x * x + y * y);
            return l <= radius;
        }
    }
}
