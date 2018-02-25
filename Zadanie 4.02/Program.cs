using System;
//Stwórz funkcję int SumaB(int a, int b) , która zwróci sumę nieparzystych 
//liczb całkowitych większych od a i mniejszych od b, obliczoną z wykorzystaniem pętli.
namespace Zadanie_4._02
{
    class Program
    {
        static int SumaB(int a, int b)
        {
            int suma = 0;
            if (b < 0)
            {
                return 0;
            }
            for (int i = a + 1; i < b; i++)
            {
                if (i % 2 != 0)
                {
                    suma += i;
                }
            }
            return suma;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SumaB(-4, 0));
            Console.ReadKey();
        }
    }
}
