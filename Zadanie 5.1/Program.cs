using System;
//Stwórz funkcję string ZwrocTablice(int[] tab, int i=0) , która zwraca zawartość
//tablicy w postaci tekstowej wykorzystując rekurencję, w formacie bez spacji
//oraz znaku przejścia do nowej linii, np.: [3,4,5,6,7,2,3]
namespace Zadanie_5._1
{
    class Program
    {
        public static string ZwrocTablice(int[] tab, int i = 0)
        {
            string a = "";
            if (i == 0)
                a += "[";
            if (i == tab.Length)
                return a + "]";
            string b = ZwrocTablice(tab, i + 1);
            a += tab[i];
            if (b != "]")
                a += ",";
            return a + b;
        }
        static void Main(string[] args)
        {
            int[] T1 = { 0, 1, 4, 3, 4, 7, 6, 7, 9 };
            Console.WriteLine(ZwrocTablice(T1));
            Console.ReadKey();
        }
    }
}
