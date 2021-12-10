using System;

namespace zad6_I_a
{
    class Class
    {
        static int[] Input()
        {
            Console.WriteLine("введите размерность массива");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; ++i)
            {
                Console.Write("a[{0}]= ", i + 1);
                a[i] = int.Parse(Console.ReadLine());
            }
            return a;
        }

        static void Print(int[] a)
        {
            for (int i = 0; i < a.Length; ++i)
            {
                Console.Write("a[{0}] = {1} | ", i + 1, a[i]);
            }
            //Console.WriteLine();
        }

        static void Change(int[] a)
        {
            for (int i = 0; i < a.Length; ++i)
                if (a[i] < 0 && a[i] % 3 != 0) a[i] = -a[i];
        }

        class Program
        {

            static void Main()
            {
                int[] array = Input();
                Console.WriteLine("Исходный массив:");
                Print(array);
                Change(array);
                Console.WriteLine();
                Console.WriteLine("Измененный массив:");
                Print(array);
            }
        }
    }
}