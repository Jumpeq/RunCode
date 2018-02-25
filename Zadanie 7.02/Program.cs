using System;
//Stwórz funkcję uint IleWyrazow1(string napis) , która zwraca liczbę wyrazów 
//znajdujących się w tekście napis. Wyrazy w tekście są oddzielone pojedynczą 
//spacją. Należy zaimplementować własny algorytm, nie korzystając z funkcji 
//klasy string (np. Split, Contains, etc.).
namespace Zadanie_7._02
{
    class Program
    {
        static uint IleWyrazow1(string napis)
        {
            int licznik = 0;
            for (int i = 0; i < napis.Length; i++)
            {
                if (napis[i] == ' ' || napis[i] == '\t' || napis[i] == '\n') licznik++;
            }
            string[] nowy = new string[licznik + 1];
            int ktoreslowo = 0;
            for (int i = 0; i < napis.Length; i++)
            {
                if (napis[i] == ' ' || napis[i] == '\t' || napis[i] == '\n')
                {
                    ktoreslowo++;
                }
                else
                {
                    //if (napis[i] != '\t' && napis[i] != '\n')
                    nowy[ktoreslowo] += napis[i];
                }
            }
            uint zlicz = 0;
            if (napis == "" || napis == " ")
            {
                return 0;
            }
            for (int i = 0; i < nowy.Length; i++)
            {
                zlicz++;
            }
            return zlicz;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IleWyrazow1(" "));
            Console.ReadKey();
        }
    }
}
