using System;

namespace zad6_III
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int n = 0;
            Console.Write("Введите размер матрицы: ");
            n = int.Parse(Console.ReadLine());
            int[,] A = new int[n, n];
            int sum = 0;
            int denom = 0;
            double res = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <n; j++)
                {
                    A[i, j] = r.Next(-10,10);
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i + j < n - 1)
                   {
                        sum += A[i, j];
                       denom++;
                        }
                    }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("a [{0}][{1}] = {2}", i + 1, j + 1, A[i, j]);
                }
            }
           res = sum / denom;
       Console.WriteLine("Среднее арифметическое ненулевых элементов над побочной диагональю = {0}", res);
        }
    }
}
