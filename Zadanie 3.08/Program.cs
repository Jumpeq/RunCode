using System;
//Stwórz funkcję: bool CzyJest(int a, int b) Funkcja zwraca wartość true, 
//jeśli w przedziale obustronnie domkniętym znajduje się liczba: 
//jednocześnie podzielna przez 3 i przez 5. Problem należy rozwiązać, 
//stosując rekurencyjne wywołanie funkcji.
namespace Zadanie_3._08
{
    class Program
    {
        static bool CzyJest(int a, int b)
        {
            if (a > b)
            {
                return false;
            }
            if (a % 3 == 0 && a % 5 == 0)
            {
                return true;
            }
            return CzyJest(a + 1, b);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CzyJest(3, 21));
            Console.ReadKey();
        }
    }
}
