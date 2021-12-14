using System;
using System.IO;
using System.Text;

namespace zad9_I
{
    class Program
    {
        static int Fibonachi(int n)
        {
            if (n == 0 || n == 1) return n;

            return Fibonachi(n - 1) + Fibonachi(n - 2);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите n:");
            int n;
            int.TryParse(Console.ReadLine(), out n);
            FileStream f = new FileStream("fib.dat", FileMode.OpenOrCreate);
            BinaryWriter fOut = new BinaryWriter(f);
            for(int i=0; i<n; i++)
            {
            fOut.Write(Fibonachi(i));
            }
            fOut.Close();
            f = new FileStream("fib.dat", FileMode.Open);
            BinaryReader fIn = new BinaryReader(f);
            long m = f.Length;
            for(int i=0; i<m; i+=4)
            {
                f.Seek(i, SeekOrigin.Begin);
                int hlam = i/4+1;
                if (hlam % 3 != 0 || i==0)
                {
                    int a = fIn.ReadInt32();

                    Console.Write($"{a} ");
                }
            }
            Console.WriteLine();
            fIn.Close();
            f.Close();
        }
    }
}
