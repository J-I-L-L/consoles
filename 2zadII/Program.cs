using System;

namespace _2zadII
{
    class Program
    {
        static void Main(string[] args)
        {
            byte num = 0;
            Console.WriteLine("Напишите число для отображения масти (Число должно быть меньше 4):");
            byte.TryParse(Console.ReadLine(), out num);
            switch (num)
            {
                case 1: Console.WriteLine("Пики"); break;
                case 2: Console.WriteLine("Трефы"); break;
                case 3: Console.WriteLine("Бубны"); break;
                case 4: Console.WriteLine("Червы"); break;
                default: Console.WriteLine("Неверное число! Попробуйте ещё раз"); break;
            }
        }
    }
}
