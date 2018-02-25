using System;
//Stwórz funkcję: ulong SumujNieparzyste(uint n) Funkcja rekurencyjnie sumuje 
//wszystkie nieparzyste liczby całkowite od 0 do liczby n (włącznie) przesłanej
//jako argument funkcji.
namespace Zadanie_3._05
{
    class Program
    {
        static ulong SumujNieparzyste(uint n)
        {
            if (n <= 0)
            {
                return 0;
            }
            if (n % 2 != 0)
            {
                return n + SumujNieparzyste(n - 1);
            }
            return SumujNieparzyste(n - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SumujNieparzyste(5));
            Console.ReadKey();
        }
    }
}
