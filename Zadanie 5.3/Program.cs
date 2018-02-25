using System;
//Stwórz funkcję string ZwrocNieparzyste2(int[] tab, int i=0) , która zwraca 
//jedynie liczby na nieparzystych indeksach w tablicy, w postaci tekstowej
//wykorzystując rekurencję, w formacie bez spacji oraz znaku przejścia 
//do nowej linii, zgodnie z kolejnością występowania, np.: [3,4,5,6]
namespace Zadanie_5._3
{
    class Program
    {
        public static string ZwrocNieparzyste2(int[] tab, int i = 1)
        {
            string a = "";
            if (i == 1)
                a += "[";
            if (i >= tab.Length)
                return a + "]";
            string b = ZwrocNieparzyste2(tab, i + 1);
            if (i % 2 == 1)
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
            Console.WriteLine(ZwrocNieparzyste2(T1));
            Console.ReadKey();
        }
    }
}
