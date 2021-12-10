using System;
using System.Linq;

namespace zad6_IV
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите n:");
            int n = Int32.Parse(Console.ReadLine());
            int[][] a = new int[n][];
            Console.WriteLine("Ввод массива:");
            for (int i = 0; i < n; i++)
            {
                a[i] = (Console.ReadLine()).Split(" ").Select(x => Int32.Parse(x)).ToArray();
            }
            Console.WriteLine("На что меняем?");
            int[] X = (Console.ReadLine()).Split(" ").Select(x => Int32.Parse(x)).ToArray();

            for (int i = 0; i < a.Length; i += 2)//Если нумерация с 0... либо поставить i = 0 изначально
                a[i] = X;
            Console.WriteLine("Изменённый массив:");
            foreach (var x in a)
            {
                foreach (var Item in x)
                {
                    Console.Write("{0}", Item);
                }
               Console.Write(" ");
            }


            Console.ReadLine();
        }
    }
}
