using System;
//Stwórz funkcję: ulong Silnia(uint n) Funkcja rekurencyjnie oblicza wartość 
//silni dla liczby n przesłanej jako argument funkcji.
namespace Zadanie_3._01
{
    class Program
    {
        static ulong Silnia(uint n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * Silnia(n - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Silnia(5));
            Console.ReadKey();
        }
    }
}
