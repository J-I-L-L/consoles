using System;

namespace _1zadII
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = 0;
            int N = 0;
            int chastnoe = 0;
            Console.WriteLine("Программа деления целых чисел:\n\n");
            Console.WriteLine("Введите первое число(делимое):");
            int.TryParse(Console.ReadLine(), out M);
            Console.WriteLine("Введите второе число (делитель):");
            int.TryParse(Console.ReadLine(), out N);
            chastnoe = M / N;
            if (M%N==0)
            {
                Console.WriteLine("\n\nЧастное деления M и N:\t{0}", chastnoe);
            }
            else
            {
                Console.WriteLine("\n\nM на N нацело не делится!");
            }
        }
    }
}
