using System;
//Stwórz funkcję string[] UsunDuplikaty(string[] wyrazy) , która zwróci tablicę 
//wyrazów z tablicy wyrazy, po usunięciu duplikatów. Kolejność wyrazów w tablicy 
//wynikowej ma być zgodna z kolejnością ich występowania w tablicy wyrazy 
//(należy brać pod uwagę pierwsze wystąpienie w tablicy). Wyrazy zawierają 
//tylko małe litery. Należy zaimplementować własny algorytm, nie korzystając
//z funkcji klasy string (np. Split, Contains, etc.).
namespace Zadanie_7._13
{
    class Program
    {
        static string[] UsunDuplikaty(string[] wyrazy)
        {
            int suma = 0;
            for (int i = 0; i < wyrazy.Length; i++)
            {
                bool czyduplikat = false;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (wyrazy[i] == wyrazy[j])
                    {
                        czyduplikat = true;
                        break;
                    }
                }
                if (czyduplikat == false)
                {
                    suma++;
                }
            }

            string[] newtab = new string[suma];
            int nowyindeks = 0;
            for (int i = 0; i < wyrazy.Length; i++)
            {
                bool czyduplikat = false;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (wyrazy[i] == wyrazy[j])
                    {
                        czyduplikat = true;
                        break;
                    }
                }
                if (!czyduplikat)
                {
                    newtab[nowyindeks] = wyrazy[i];
                    nowyindeks++;
                }
            }
            string a = "[";
            if (newtab.Length > 0)
            {
                a += newtab[0];
                for (int u = 1; u < newtab.Length; u++)
                    a += ", " + newtab[u];
            }
            Console.WriteLine(a + "]");
            return newtab;
        }
        static void Main(string[] args)
        {
            string[] tab = { "mama", "lej", "mama", "kot", "lej" };
            UsunDuplikaty(tab);
            Console.ReadKey();
        }
    }
}
