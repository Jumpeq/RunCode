using System;
//Stwórz funkcję uint Suma3(int a, int b) , która z wykorzystaniem pętli obliczy, 
//ile jest liczb pierwszych większych od a oraz mniejszych od b.
namespace Zadanie_4._08
{
    class Program
    {
        static uint Suma3(int a, int b)
        {
            uint ile = 0;
            if (b < 0)
                return ile;
            if (a <= 0 && b > 0)
            {
                int licznik = 0;
                for (int i = 0; i < b; i++)
                {
                    licznik = 0;
                    for (int j = 2; j <= i; j++)
                    {
                        if (i % j == 0)
                            licznik++;
                    }
                    if (licznik == 1)
                        ile++;
                }
            }
            if (a > 0)
            {
                int licznik = 0;
                for (int i = a + 1; i < b; i++)
                {
                    licznik = 0;
                    for (int j = 2; j <= i; j++)
                    {
                        if (i % j == 0)
                            licznik++;
                    }
                    if (licznik == 1)
                        ile++;
                }
            }
            return ile;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Suma3(2, 10));
            Console.ReadKey();
        }
    }
}
