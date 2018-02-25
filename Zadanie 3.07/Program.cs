using System;
//Stwórz funkcję: long PomnozNiepodzielne(int n) Funkcja rekurencyjnie oblicza
//iloczyn wszystkich liczb całkowitych znajdujących się między liczbą
//n przesłaną jako argument funkcji a liczbą 0 (wyłączając 0), które 
//jednocześnie spełniają obydwa warunki: są niepodzielne przez 7 oraz 
//niepodzielne przez 5. Dla n = 0 funkcja zwraca 0.
namespace Zadanie_3._07
{
    class Program
    {
        static long PomnozNiepodzielne(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1 || n == -1)
            {
                return n;
            }
            if (n > 0)
            {
                if (n % 7 != 0 && n % 5 != 0)
                {
                    return n * PomnozNiepodzielne(n - 1);
                }
                return PomnozNiepodzielne(n - 1);
            }
            if (n < 0 && n % 7 != 0 && n % 5 != 0)
            {
                return n * PomnozNiepodzielne(n + 1);
            }
            return PomnozNiepodzielne(n + 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(PomnozNiepodzielne(-5));
            Console.ReadKey();
        }
    }
}
