using System;

namespace EX11While
{
    class Program
    {
        static void Main(string[] args)
        {

            //OPG 11.1
            int i = 1;
            int l = 10;
            int j = 3;
            int k = 1;
            Console.WriteLine("1 til 10");

            while (i <= 10)
            {
                Console.WriteLine(i);

                i++;
            }
            Console.WriteLine("\n10 til 1");
            while (l >= 1)
            {
                Console.WriteLine(l);
                l--;
            }
            Console.WriteLine("\nAlle lige tal fra 1 til 20");
            while (j <= 20)
            {
                Console.WriteLine(j);
                j = j + 2;
            }
            Console.WriteLine("\nAlle ulige tal fra 1 til 20");
            while (k <= 20)
            {
                Console.WriteLine(k);
                k = k + 2;
            }
            

            Console.ReadKey();
        }
    }
}
