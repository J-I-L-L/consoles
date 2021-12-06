using System;

namespace Z041
{
    class prac
    {
        int a, b;
        public prac()
        {
            while (true)
            {
                Console.WriteLine("Введите два ЦЕЛЫХ числа:");
                if (Int32.TryParse(Console.ReadLine(), out a) &&
                Int32.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("НОД двух введённых чисел равен:\t" + nod(Math.Abs(a), Math.Abs(b)));
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели что-то не то, попробуйте ещё раз");
                }

            }
        }
        int nod(int a, int b)
        {
            if (a == b)
            {
                return a;
            }
            else if (a > b)
            {
                return nod(a - b, b);
            }
            else
            {
                return nod(a, b - a);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            prac p = new prac();
        }
    }
}