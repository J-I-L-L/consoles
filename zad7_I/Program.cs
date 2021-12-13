using System;
using System.Text;

namespace zad7_I
{
    class Program
    {
        static void Main(string[] args)
        {
            int numerous=0;
            Console.WriteLine("Введите строку:");
            string a = new string(Console.ReadLine());
            string str=a.ToLower();
            Console.Write("Введите символ х (строчная буква): ");
            char x = char.Parse(Console.ReadLine());
            Console.Write("Введите символ у(строчная буква):");
            char y = char.Parse(Console.ReadLine());
            for(int i=0; i<a.Length; i++)
            {

                if (str[i]==x || str[i]==y)
                {
                    numerous++;
                }
            }
            Console.WriteLine("Число вхождений символов Х и Y в строке: " +numerous);
        }
    }
}
