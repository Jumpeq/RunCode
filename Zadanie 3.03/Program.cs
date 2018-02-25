using System;
//Stwórz funkcję: int Dodaj2(int n) Funkcja rekurencyjnie oblicza sumę 
//wszystkich liczb całkowitych od 0 do liczby n (włącznie) przesłanej
//jako argument funkcji.
namespace Zadanie_3._03
{
    class Program
    {
        static int Dodaj2(int n)
        {
            if (n > 0)
            {
                return n + Dodaj2(n - 1);
            }
            else if (n == 0)
            {
                return 0;
            }
            else
            {
                return n + Dodaj2(n + 1);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Dodaj2(-5));
            Console.ReadKey();
        }
    }
}
