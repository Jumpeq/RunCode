using System;
//Stwórz funkcję int[] WiekszeOdSredniej(int[] tab) , która zwraca tablicę zawierającą 
//tylko te liczby z tablicy tab, które są co najmniej dwukrotnie większe od średniej ze 
//wszystkich liczb w tablicy (tzn. znajdują się w przedziale (2*średnia; max], gdzie max
//to element maksymalny w tablicy). Rozmiar zwracanej tablicy ma być równy liczbie 
//znalezionych liczb spełniających warunki w tablicy T.
namespace Zadanie_6._09
{
    class Program
    {
        static int[] WiekszeOdSredniej(int[] tab)
        {
            if (tab.Length == 0) return null;
            int suma = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                suma += tab[i];
            }
            int srednia = suma / (tab.Length);
            int max = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] > max)
                    max = tab[i];
            }
            int ile = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] > 2 * srednia && tab[i] <= max)
                {
                    ile++;
                }
            }
            int[] wynik = new int[ile];
            ile = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] > 2 * srednia && tab[i] <= max)
                {
                    wynik[ile] = tab[i];
                    ile++;
                }
            }
            string a = "[";
            if (wynik.Length > 0)
            {
                a += wynik[0];
                for (int i = 1; i < wynik.Length; i++)
                    a += ", " + wynik[i];
            }
            Console.WriteLine(a + "]");
            return wynik;
        }
        static void Main(string[] args)
        {
            int[] tab = { 1, 2, 1, 1, 1, 5, 8 };
            WiekszeOdSredniej(tab);
            Console.ReadKey();
        }
    }
}
