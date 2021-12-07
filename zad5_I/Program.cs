using System;

namespace zad5_I
{
    class Program
    {
        static double f(double x)
        {
            try
            {
                if (x == 0)
                {
                    throw new Exception();
                }
                else
                {
                    return Math.Sqrt(x * x - 1);
                }
            }
            catch
            {
                throw;
            }
        }
        static void Main(string[] args)
        {
            try
            {
                double a = 0;
                double b = 0;
                double h = 0;
                Console.WriteLine("Введите a:");
                a=double.Parse(Console.ReadLine());
                Console.WriteLine("Введите b:");
                b=double.Parse(Console.ReadLine());
                Console.WriteLine("Введите h:");
                h=double.Parse(Console.ReadLine());
                for (double i = a; i <= b;)
                {
                    try
                    {
                        Console.WriteLine("y[{0}]= {1:f4}", i, f(i));
                    }
                    catch
                    {
                        Console.WriteLine("y[{0}] = error", i);
                    }
                    i = i + h;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Введенно неверное значение. Попробуйте снова.");
            }
        }
    }
}

