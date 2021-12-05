using System;

namespace zad3_III
{
    class Program
    {
        static double f(double x, out double y)
        {
            y = 0;
            //double y = 0;
            if (x >= 0.9)
            {
                y = 1 / ((0.1 + x) * (0.1 + x));
            }
            else if (x >= 0 && x <= 0.9)
            {
                y = 0.2 * x + 0.1;
            }
            else if (x < 0)
            {
                y = x * x + 0.2;
            }
            return y;
        }
        static void Main(string[] args)
        {
            double a = 0;
            double b = 0;
            double h = 0;
            double otv = 0;
            Console.WriteLine("Введите а:");
            double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Введите b:");
            double.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("Введите h:");
            double.TryParse(Console.ReadLine(), out h);
            for (double i = a; i <= b; i = i + h)
            {
                f(i, out otv);
                Console.WriteLine("f ({0:f1}) = {1:f4}", i, otv);
            }
        }
    }
}
