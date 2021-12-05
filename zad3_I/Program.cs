using System;

namespace zad3_I
{
    class Program
    {

        static double f(double x)
        {
            double func = Math.Pow(x, 3) - Math.Sin(x);
            return func;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Программа для определения наибольшего значения в одной из двух точек");
            double a = 0;
            double aX = 0;
            double b=0;
            double bX = 0;
            Console.WriteLine("Введите координату Х точки а:");
            double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Введите координату Х точки b:");
            double.TryParse(Console.ReadLine(), out b);
            aX = f(a);
            bX = f(b);
            if (aX > bX)
            {
                Console.WriteLine("Значение функции больше в точке а");
            }
            else
            {
                Console.WriteLine("Значение функции выше в точке b");
            }
        }
    }
}
