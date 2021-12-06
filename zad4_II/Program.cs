using System;

namespace zad4_II
{
    class Program
    {
        public static void output(int n)
        {
            if (n == 1) Console.Write(n+ " ");
            else
            {
                output(n - 1);
                Console.Write(n+" ");
            }
        }

        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Введите число");
            Int32.TryParse(Console.ReadLine(), out n);
            if (n < 1000)
            {
                Console.WriteLine("n<1000. Введите другое число");
            } else
            {
                output(n);
            }
        }
    }
}
