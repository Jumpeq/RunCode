using System;
//Stwórz funkcję string ZwrocNieparzyste1(int[] tab, int i=0) , która zwraca 
//jedynie nieparzyste liczby z tablicy, w postaci tekstowej wykorzystując 
//rekurencję, w formacie bez spacji oraz znaku przejścia do nowej linii, 
//zgodnie z kolejnością występowania, np.: [3,5,7,3]
namespace Zadanie_5._2
{
    class Program
    {
        public static string ZwrocNieparzyste1(int[] tab, int i = 0)
        {
            string a = "";
            if (i == 0)
                a += "[";
            if (i == tab.Length)
                return a + "]";
            string b = ZwrocNieparzyste1(tab, i + 1);
            if (tab[i] % 2 == 1)
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
            Console.WriteLine(ZwrocNieparzyste1(T1));
            Console.ReadKey();
        }
    }
}
