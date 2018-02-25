using System;
//Stwórz funkcję: string ZwrocNiepodzielne(uint n) Funkcja zwraca w postaci tekstu 
//ciąg kolejnych liczb całkowitych znajdujących się między liczbą 0 a liczbą
//n przesłaną jako argument funkcji, które są niepodzielne przez 3 lub przez 5 
//(lub przez obydwie z tych liczb). Tekst ma zawierać liczby w kolejności rosnącej,
//w jednej linii, oddzielone spacją od siebie, np: "1 2 4 7" (bez cudzysłowu). 
//Przed pierwszą liczbą oraz po ostatniej liczbie brak spacji.
//Problem należy rozwiązać, stosując rekurencyjne wywołanie funkcji.
namespace Zadanie_3._06
{
    class Program
    {
        static string ZwrocNiepodzielne(uint n)
        {
            if (n <= 0)
            {
                return "";
            }
            if (!(n % 3 == 0 || n % 5 == 0))
            {
                if (ZwrocNiepodzielne(n - 1) != "")
                    return ZwrocNiepodzielne(n - 1) + " " + n.ToString();
                return ZwrocNiepodzielne(n - 1) + n.ToString();
            }
            return ZwrocNiepodzielne(n - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ZwrocNiepodzielne(7));
            Console.ReadKey();
        }
    }
}
