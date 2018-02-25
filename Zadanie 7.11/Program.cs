using System;
//Stwórz funkcję uint IlePalindromowWTablicy(string[] wyrazy) , która zwróci liczbę 
//wyrazów z tablicy wyrazy, które są palindromami. Wszystkie wyrazy zawierają tylko 
//małe litery. Należy zaimplementować własny algorytm, nie korzystając z funkcji 
//klasy string (np. Split, Contains, etc.).
namespace Zadanie_7._11
{
    class Program
    {
        static uint IlePalindromowWTablicy(string[] wyrazy)
        {
            uint licznik = 0;
            uint zlicz = 0;
            for (int i = 0; i < wyrazy.Length; i++)
            {
                string tmp = wyrazy[i];
                for (int j = 0; j < tmp.Length; j++)
                {
                    if (tmp[j] == tmp[tmp.Length - 1 - j])
                    {
                        licznik++;
                    }
                }
                if (licznik == tmp.Length)
                {
                    zlicz++;
                }
                licznik = 0;
            }
            return zlicz;
        }
        static void Main(string[] args)
        {
            string[] tab1 = { "sedes", "kajak", "bulka", "kajak" };
            Console.WriteLine(IlePalindromowWTablicy(tab1));
            Console.ReadKey();
        }
    }
}
