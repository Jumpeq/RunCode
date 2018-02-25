using System;
//Stwórz funkcję bool CzyDwieWTablicy(double[] T, double a) , która zwraca true,
//jeśli w tablicy T znajdują się dokładnie dwa wystąpienia liczby a 
//(przesłanej jako argument funkcji) na nieparzystych indeksach tablicy. 
//W przeciwnym wypadku funkcja zwraca false.
namespace Zadanie_6._07
{
    class Program
    {
        static bool CzyDwieWTablicy(double[] T, double a)
        {
            int licznik = 0;
            for (int i = 0; i < T.Length; i++)
            {
                if (T[i] == a && i % 2 != 0)
                    licznik++;
            }
            if (licznik == 2)
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            double[] tab = { 1, 2, 3, 4, 2, 2 };
            Console.WriteLine(CzyDwieWTablicy(tab, 2));
            Console.ReadKey();
        }
    }
}
