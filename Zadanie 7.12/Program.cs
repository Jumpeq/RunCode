using System;
//Stwórz funkcję uint IlePalindromowWNapisie(string tekst) , która zwróci liczbę wyrazów, 
//które są palindromami w napisie tekst. Wyrazy w napisie są oddzielone spacją i zawierają 
//tylko małe litery. Należy zaimplementować własny algorytm, nie korzystając z funkcji 
//klasy string (np. Split, Contains, etc.).
namespace Zadanie_7._12
{
    class Program
    {
        static uint IlePalindromowWNapisie(string tekst)
        {
            if (tekst == "" || tekst == " ")
                return 0;
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
                {
                    ktoreslowo++;
                }
                else
                {
                    wynik[ktoreslowo] += tekst[i];
                }
            }

            int licznik2 = 0;
            uint zlicz = 0;
            for (int i = 0; i < wynik.Length; i++)
            {
                string tmp = wynik[i];
                for (int j = 0; j < tmp.Length; j++)
                {
                    if (tmp[j] == tmp[tmp.Length - 1 - j])
                    {
                        licznik2++;
                    }
                }
                if (licznik2 == tmp.Length)
                {
                    zlicz++;
                }
                licznik2 = 0;
            }
            return zlicz;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IlePalindromowWNapisie(" "));
            Console.ReadKey();
        }
    }
}
