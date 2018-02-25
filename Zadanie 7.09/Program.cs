using System;
//Stwórz funkcję string[] ZwrocWyrazy1(string tekst) , która zwróci tablicę wszystkich 
//wyrazów odczytanych z napisu tekst. Kolejność napisów w tablicy ma być zgodna z 
//kolejnością ich występowania w tekście. Znak oddzielający wyrazy w napisie tekst to
//pojedyncza spacja, a wyrazy zawierają jedynie małe litery. Rozmiar zwracanej tablicy ma 
//być równy liczbie wszystkich wyrazów w tekście. Należy zaimplementować własny algorytm, 
//nie korzystając z funkcji klasy string (np. Split, Contains, etc.).
namespace Zadanie_7._09
{
    class Program
    {
        static string[] ZwrocWyrazy1(string tekst)
        {
            int licznik = 0;
            for (int i = 0; i < tekst.Length; i++)
            {
                if (tekst[i] == ' ') licznik++;
            }
            string[] wynik = new string[licznik + 1];
            int ktoreslowo = 0;
            for (int i = 0; i < tekst.Length; i++)
            {
                if (tekst[i] == ' ')
                    ktoreslowo++;
                else
                {
                    wynik[ktoreslowo] += tekst[i];
                }
            }
            return wynik;
        }
        static void Wypisz(string[] tab)
        {
            Console.Write(tab[0]);
            for (int i = 1; i < tab.Length; i++)
                Console.Write(";" + tab[i]);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            string[] wyraz = ZwrocWyrazy1("lolo hehe ojć");
            Wypisz(wyraz);
            Console.ReadKey();
        }
    }
}
