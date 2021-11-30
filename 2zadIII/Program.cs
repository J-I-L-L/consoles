using System;

namespace _2zadIII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выведение чисел в определённом порядке\n\n");
            Console.WriteLine("Способ через While:\n");
            int i = 25;
            while (i <= 35)
            {
                Console.WriteLine(i + "  " +(i+0.5) + "  " +(i-0.2));
                i++;
            }
            Console.WriteLine("\nСпособ через Do While:\n");
            int j = 25;
            do
            {
                Console.WriteLine(j + "  " + (j + 0.5) + "  " + (j - 0.2));
                j++;
            } while (j <= 35);
            Console.WriteLine("\nСпособ через For:\n");
            int k = 25;
            for(; k<=35; k++)
            {
                Console.WriteLine(k + "  " + (k + 0.5) + "  " + (k - 0.2));
            }
        }
    }
}
