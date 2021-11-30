using System;

namespace _2zadI
{
    class Program
    {
        static void Main(string[] args)
        {
            double x=0.0;
            double y = 0.0;
            Console.WriteLine("Введите Х:");
            double.TryParse(Console.ReadLine(), out x);
            Console.WriteLine("Введите Y:");
            double.TryParse(Console.ReadLine(), out y);
            if(x*x+y*y<64 && x * x + y * y > 9 && x <= 0)
            {
                Console.WriteLine("Точка находится внути закрашенной области");
            } else if(x * x + y * y == 64 || x*x+y*y == 9 && x <= 0)
            {
                Console.WriteLine("Точка находится на границе закрашенной области");
            }
            else
            {
                Console.WriteLine("Точка находится ВНЕ закрашенной области");
            }
        }
    }
}
