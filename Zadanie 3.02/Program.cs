using System;
//Stwórz funkcję: uint Dodaj1(uint n) Funkcja rekurencyjnie oblicza sumę
//wszystkich liczb całkowitych od 0 do liczby n (włącznie) przesłanej 
//jako argument funkcji.
namespace Zadanie_3._02
{
    class Program
    {
        static uint Dodaj1(uint n)
        {
            if (n == 0)
            {
                return 0;
            }
            return n + Dodaj1(n - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Dodaj1(5));
            Console.ReadKey();
        }
    }
}
