using System;

namespace zad11_I
{
    class Rectangle
    {
        int a, b;
        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public void OutputInfo()
        {
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("Периметр =\t" + Perimetr());
            Console.WriteLine("Площадь =\t" + Ploshad());
        }
        public int Perimetr()
        {
            return a + a + b + b;
        }
        public int Ploshad()
        {
            return a * b;
        }
        public int A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }
        public int B
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }
        public bool SquareCheck
        {
            get
            {
                if (a == b)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, bufA, bufB;
            while (true)
            {
                Console.WriteLine("Введите стороны прямоугольника (целочисленные): ");
                if (Int32.TryParse(Console.ReadLine(), out a) && Int32.TryParse(Console.ReadLine(), out b) && a > 0 && b > 0) { break; }
                else { Console.WriteLine("Стороны прямогульника должны принимать целые положительные значения"); }
            }
            Rectangle rec = new Rectangle(a, b);
            Console.WriteLine("\nДанные о прямоугольнике:");
            rec.OutputInfo();
            Console.WriteLine("---------------------------------------");
            Console.Write("Введите новое значение A: ");
            if (Int32.TryParse(Console.ReadLine(), out bufA))
            {
                Console.WriteLine("Данные до изменения: " + rec.A);
                rec.A = bufA;
                Console.WriteLine("Данные после изменения: " + rec.A);
                Console.WriteLine("---------------------------------------");
            }
            else
            {
                Console.WriteLine("Вы ввели не число/ не целое число");
                Console.WriteLine("---------------------------------------");
            }
            Console.WriteLine("---------------------------------------");
            Console.Write("Введите новое значение B: ");
            if (Int32.TryParse(Console.ReadLine(), out bufB))
            {
                Console.WriteLine("Данные до изменения: " + rec.B);
                rec.B = bufB;
                Console.WriteLine("Данные после изменения: " + rec.B);
                Console.WriteLine("---------------------------------------");
            }
            else 
            { Console.WriteLine("Вы ввели не число/ не целое число");
                Console.WriteLine("---------------------------------------");
            }

            if (rec.SquareCheck)
            {
                Console.WriteLine("Фигура - квадрат.");
            }
            else
            {
                Console.WriteLine("Фигура - не квадрат.");
            }
        }
    }
}