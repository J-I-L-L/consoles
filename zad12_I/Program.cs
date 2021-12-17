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
        public int this[int index]
        {
            get
            {
                if (index == 0) return A;
                if (index == 1) return B;
                else
                {
                    Console.WriteLine("Введён неверный индекс! ({0})", index);
                    return 0;
                }
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

        public static Rectangle operator ++(Rectangle side) => new Rectangle(++side.a, ++side.b);

        public static Rectangle operator --(Rectangle side) => new Rectangle(--side.a, --side.b);

        public static bool operator true(Rectangle side) => side.SquareCheck;
        public static bool operator false(Rectangle side) => side.SquareCheck;

        public static Rectangle operator *(Rectangle side, int scl)=> new Rectangle(side.a = side.a * scl, side.b = side.b * scl);

        public static explicit operator string(Rectangle side)
        {
            return ($"{side.a.ToString()} {side.b.ToString()}");
        }

        public static explicit operator Rectangle(string str)
        {
            string[] buf = str.Split(" ");
            Rectangle retBuf = new Rectangle(Convert.ToInt32(buf[0]), Convert.ToInt32(buf[1]));
            return retBuf;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, bufA, bufB;
            int indA = 0;
            int indB = 0;
            int indE = 0;
            while (true)
            {
                Console.WriteLine("Введите стороны прямоугольника (целочисленные): ");
                if (Int32.TryParse(Console.ReadLine(), out a) && Int32.TryParse(Console.ReadLine(), out b) && a > 0 && b > 0) { break; }
                else { Console.WriteLine("Стороны прямогульника должны принимать целые положительные значения"); }
            }
            Rectangle rec = new Rectangle(a, b);
            Console.WriteLine("Обращение по индексу:");
            indA = rec[0];
            indB=rec[1];
            
            Console.WriteLine("Индекс 0 ={0}", indA);
            Console.WriteLine("Индекс 1 ={0}", indB);
            indE = rec[6];
            Console.WriteLine("\nДанные о прямоугольнике:");
            rec.OutputInfo();
            Console.WriteLine("Увеличиваем поля на 1 перегруженым оператором ++");
            ++rec;
            rec.OutputInfo();
            Console.WriteLine("Уменьшаем поля на 1 перегруженым оператором --");
            --rec;
            rec.OutputInfo();
            Console.WriteLine("Умножаем на скаляр (2 в этом примере) перегруженным оператором *");
            rec*=2;
            rec.OutputInfo();
            Console.WriteLine("Проверяем на квадрат перегруженными true и false");
            if (rec)
            {
                Console.WriteLine("Фигура является квадратом");
            }
            else
            {
                Console.WriteLine("Фигура не является квадратом");
            }
            Console.WriteLine("Задаём новые стороны (5, 6) в конструкторе и явно приводим к строке");
            Rectangle recto = new Rectangle(5, 6);
            string bufRecto = (string)recto;
            Console.WriteLine("{0}", bufRecto);
            Console.WriteLine("А здесь наоборот, задаём числа в строке и приводим к созданному классу Rectangle");
            string recagain = "22 55";
            Rectangle bufRecAgain = (Rectangle)recagain;
            bufRecAgain.OutputInfo();
        }
    }
}