using System;

namespace zad7_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int buf = 0;
            string str = "";
            string[] words;
            str = Console.ReadLine();
            words = str.Split();
            for(int i=0; i<words.Length; i++)
            {
                buf = words[i].Length;
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (Char.IsDigit(words[i][j]))
                    {
                        for(int z=0; z<words[i].Length; z++)
                        {
                            if (words[i][z] != ',')
                                if (words[i][z] != '?')
                                    if (words[i][z] != '.')
                                        if (words[i][z] != '!')
                                            if (words[i][z] != ';')
                                                Console.Write(words[i][z]);
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
