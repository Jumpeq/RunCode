using System;
//Stwórz funkcję int Potega(int n, uint w) , obliczającą z wykorzystaniem 
//pętli wartość liczby n podniesionej do potęgi w.
namespace Zadanie_4._11
{
    class Program
    {
        static int Potega(int n, uint w)
        {
            int pot = 1;
            for (int i = 1; i <= w; i++)
            {
                pot *= n;
            }
            return pot;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Potega(2, 0));
            Console.ReadKey();
        }
    }
}
