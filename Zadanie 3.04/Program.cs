using System;
//Stwórz funkcję: long Pomnoz(int n) Funkcja rekurencyjnie oblicza iloczyn wszystkich 
//liczb całkowitych znajdujących się między liczbą n (włącznie) przesłaną jako argument
//funkcji a liczbą 0 (wyłączając 0). Dla n = 0 funkcja zwraca 0.
namespace Zadanie_3._04
{
    class Program
    {
        static long Pomnoz(int n)
        {
            if (n > 1)
            {
                return n * Pomnoz(n - 1);
            }
            else if (n == 0)
            {
                return 0;
            }
            else if (n < -1)
            {
                return n * Pomnoz(n + 1);
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Pomnoz(0));
            Console.ReadKey();
        }
    }
}
