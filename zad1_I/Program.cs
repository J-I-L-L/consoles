using System;

namespace ConsoleFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeration = 0;
            double number = 0.0;
            double completeSumm = 0.0;
            double average = 0.0;
            Console.WriteLine("Программа для высчитывания среднего арифметического кубов данных чисел:\n\n");
            Console.WriteLine("Введите количество чисел:");
            int.TryParse(Console.ReadLine(),out  numeration);
            double[] numArray = new double[numeration];
            for (int i = 0; i < numeration; i++)
            {
                Console.WriteLine("Введите " + (i + 1) + " число:\t");
                double.TryParse(Console.ReadLine(), out number);
                numArray[i] = Math.Pow(number, 3);
                completeSumm += numArray[i];
            }
            average = completeSumm / numeration;
            Console.WriteLine("Итак, среднее арифметическое кубов данных чисел равно:\t" + average);
        }
    }
}
