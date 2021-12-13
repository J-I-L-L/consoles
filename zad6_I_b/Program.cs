using System;

namespace zad6_I_b
{
    class Program
    {
        static int [,] Input(out int n, out int m)
        {
            Console.WriteLine("Введите размерность массива:");
            Console.Write("N= ");
            n = int.Parse(Console.ReadLine());
            Console.Write("M= ");
            m = int.Parse(Console.ReadLine());
            int[,] a = new int[n, m];
            for(int i=0; i<n; i++)
            {
                for(int j=0; j<m; j++)
                {
                    Console.Write("a [{0},{1}] = ", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return a;
        }

        static void Print(int[,] a)
        {
            for(int i=0; i<a.GetLength(0); ++i, Console.WriteLine())
            {
                for(int j=0; j<a.GetLength(1); ++j)
                {
                    Console.Write("{0,5} ", a[i, j]);
                }
            }
        }

        static void Change(int[,] a)
        {
            for(int i=0; i<a.GetLength(0); ++i)
            {
                for (int j = 0; j < a.GetLength(1); ++j)
                {
                    if (a[i,j]<0 && a[i, j] % 3 != 0)
                    {
                        a[i, j] = -a[i, j];
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int n, m;
            int[,] array = Input(out n, out m);
            Console.WriteLine("Исходный массив:");
            Print(array);
            Change(array);
            Console.WriteLine("Изменённый массив:");
            Print(array);
        }
    }
}
