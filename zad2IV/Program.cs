using System;

namespace zad2IV
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=4; i<=7; i++)
            {
                for(int j=1; j<=9; j++)
                {
                   
                    Console.Write(" "+i + j+" ");
                }
                Console.WriteLine(" "+(i+1)+"0");
            }
        }
    }
}
