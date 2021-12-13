using System;
using System.Text.RegularExpressions;
using System.Text;

namespace zad8_I
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите осмысленное сообщение:");
            string str="";
            string[] words;
            str = Console.ReadLine();
            words = str.Split(' ', '.', ',', '?', '!', ':', ';');
            Regex reg = new Regex(@"[А-Я]\S*"); 
            foreach(var i in reg.Matches(str))
            {
                Console.WriteLine(i);
            }
        }
    }
}
