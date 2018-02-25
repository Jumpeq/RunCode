using System;
//Stwórz funkcję string ZwrocPodzielne(int[] tab, int n, int i=0) , która zwraca 
//jedynie liczby podzielne przez n z tablicy, w postaci tekstowej wykorzystując 
//rekurencję, w formacie bez spacji oraz znaku przejścia do nowej linii, 
//zgodnie z kolejnością występowania, np.: [3,4,8,6]
namespace Zadanie_5._4
{
    class Program
    {
        public static string ZwrocPodzielne(int[] tab, int liczba, int i = 0)
        {
            string a = "";
            if (i == 0)
                a += "[";
            if (i == tab.Length)
                return a + "]";
            string b = ZwrocPodzielne(tab, liczba, i + 1);
            if (tab[i] % liczba == 0)
            {
                a += tab[i];
                if (b != "]")
                    a += ",";
            }
            return a + b;
        }
        static void Main(string[] args)
        {
            int[] T1 = { 0, 1, 4, 3, 4, 7, 6, 7, 9 };
            Console.WriteLine(ZwrocPodzielne(T1, 3));
            Console.ReadKey();
        }
    }
}
