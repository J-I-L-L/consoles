using System;

namespace zad6_II
{
    class Program
    {
        static int[] Input()
        {
            Console.Write("Введите размерность массива: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for(int i=0; i<n; ++i)
            {
                Console.Write("а[{0}] = ", i+1);
                a[i] = int.Parse(Console.ReadLine());
            }
            return a;
        }

        static int Min(int[] a)
        {
            int min = a[0];
            for(int i=1; i<a.Length; ++i)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            return min;
        }

        static void Main(string[] args)
        {
            int[] array = Input();
            int min = Min(array);
            for(int i=0; i<array.Length; ++i)
            {
                if (array[i] == min)
                {
                    array[i] = -array[i];
                }
            }
            Console.WriteLine("Изменённый массив:");
            for(int i=0; i<array.Length; ++i)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
