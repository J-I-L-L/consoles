using System;
using System.Text;
using System.IO;

namespace zad9_II
{
    class Program
    {
        public static string ShortestString(string fileName)
        {
            string currentString, shortestString = "";
            int buf = Int32.MaxValue;
            using (StreamReader reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    currentString = reader.ReadLine();
                    if (currentString.Length < buf)
                        buf = shortestString.Length;
                        shortestString = currentString;
                }
                return shortestString;
            }
        }
        static void Main(string[] args)
        {
            //StreamReader fileIn = new StreamReader("memory.txt");
            //string text = fileIn.ReadToEnd();
            string shortStr = ShortestString("memory.txt");
            Console.WriteLine("Кратчайшая строка: {0}",shortStr);
            Console.WriteLine("И её длина: {0}",shortStr.Length);
           // fileIn.Close();
        }
    }
}
