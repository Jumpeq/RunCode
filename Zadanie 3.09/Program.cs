using System;
//Stwórz funkcję: bool CzySasiaduje(int a, int b) Funkcja zwraca wartość true, 
//jeśli w przedziale obustronnie domkniętym znajduje się taka para sąsiadujących 
//ze sobą liczb x i y, że x jest podzielne przez 5, a y podzielne przez 3. 
//Problem należy rozwiązać, stosując rekurencyjne wywołanie funkcji.
namespace Zadanie_3._09
{
    class Program
    {
        static bool CzySasiaduje(int a, int b)
        {
            int x = a;
            int y = a + 1;
            if (y <= b)
            {
                if ((x % 5 == 0 && y % 3 == 0) || (x % 3 == 0 && y % 5 == 0))
                {
                    return true;
                }
            }
            if (y > b)
            {
                return false;
            }
            return CzySasiaduje(a + 1, b);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CzySasiaduje(5, 10));
            Console.ReadKey();
        }
    }
}
