using System;
//Stwórz funkcję string[] ZwrocPalindromy(string tekst) , która zwraca te wyrazy z 
//tekstu tekst, które są palindromami, bez duplikatów. Kolejność palindromów 
//w tablicy ma być zgodna z kolejnością ich występowania w tekście (należy brać 
//pod uwagę pierwsze wystąpienie w tekście). Funkcja zwraca tablicę wszystkich
//znalezionych wyrazów-palindromów. Rozmiar zwracanej tablicy ma być równy 
//liczbie wszystkich palindromów. Wyrazy zawierają tylko małe litery.
//Wyrazy w tekście mogą być oddzielone dowolnym ciągiem znaków-separatorów 
//(np. dwie spacje, wielokropek, etc.). Należy zaimplementować własny algorytm, 
//nie korzystając z funkcji klasy string (np. Split, Contains, etc.).
namespace Zadanie_7._14
{
    class Program
    {
        static string[] ZwrocPalindromy(string tekst)
        {
            string tmp = "";
            //zamiana z dużych na małe literki
            for (int i = 0; i < tekst.Length; i++)
            {
                if (tekst[i] >= 'A' && tekst[i] <= 'Z')
                {
                    tmp += Convert.ToChar(tekst[i] + ('a' - 'A'));
                }
                else
                {
                    tmp += tekst[i];
                }
            }
            //licznik parsowania poczymkolwiek
            int licznik = 0;
            for (int i = 0; i < tmp.Length - 1; i++)
            {
                if ((tmp[i] >= 'a' && tmp[i] <= 'z') && (tmp[i + 1] < 'a' || tmp[i + 1] > 'z')) licznik++;
            }
            //if dla przypadku jeżeli ostatni wyraz ciągu nie jest literką, aby
            //nie został uwzględniony
            if (tmp[tmp.Length - 1] < 'a' || tmp[tmp.Length - 1] > 'z')
            {
                licznik = licznik - 1;
            }
            string[] nowy = new string[licznik + 1];
            int ktoreslowo = 0;
            //zapisywanie całych słów
            for (int i = 0; i < tmp.Length - 1; i++)
            {
                if ((tmp[i] >= 'a' && tmp[i] <= 'z') && (tmp[i + 1] < 'a' || tmp[i + 1] > 'z'))
                {
                    nowy[ktoreslowo] += tmp[i];
                    ktoreslowo++;
                }
                else if (tmp[i] >= 'a' && tmp[i] <= 'z')
                {
                    nowy[ktoreslowo] += tmp[i];
                }
            }
            if (tmp[tmp.Length - 1] >= 'a' && tmp[tmp.Length - 1] <= 'z')
            {
                nowy[ktoreslowo] += tmp[tmp.Length - 1];
            }
            //funkcja co sprawdza duplikaty
            int suma = 0;
            for (int i = 0; i < nowy.Length; i++)
            {
                bool czyduplikat = false;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (nowy[i] == nowy[j])
                    {
                        czyduplikat = true;
                        break;
                    }
                }
                if (!czyduplikat)
                {
                    suma++;
                }
            }

            string[] newtab = new string[suma];
            int nowyindeks = 0;

            for (int i = 0; i < nowy.Length; i++)
            {
                bool czyduplikat = false;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (nowy[i] == nowy[j])
                    {
                        czyduplikat = true;
                        break;
                    }
                }
                if (!czyduplikat)
                {
                    newtab[nowyindeks] = nowy[i];
                    nowyindeks++;
                }
            }
            //funkcja co sprawdza czy palindromy
            int ile1 = 0;
            for (int i = 0; i < newtab.Length; i++)
            {
                string tmp2 = newtab[i];
                bool czypalindrom = false;
                for (int j = 0; j < tmp2.Length; j++)
                {
                    if (tmp2[j] != tmp2[tmp2.Length - 1 - j])
                    {
                        czypalindrom = true;
                        break;
                    }
                }
                if (!czypalindrom)
                {
                    ile1++;
                }
            }
            string[] wynik = new string[ile1];
            int index = 0;
            for (int i = 0; i < newtab.Length; i++)
            {
                string tmp2 = newtab[i];
                bool czypalindrom = false;
                for (int j = 0; j < tmp2.Length; j++)
                {
                    if (tmp2[j] != tmp2[tmp2.Length - 1 - j])
                    {
                        czypalindrom = true;
                        break;
                    }
                }
                if (!czypalindrom)
                {
                    wynik[index] = tmp2;
                    index++;
                }
            }

            //wypisywanie tablicy elementów
            string a = "[";
            if (wynik.Length > 0)
            {
                a += wynik[0];
                for (int u = 1; u < wynik.Length; u++)
                    a += ", " + wynik[u];
            }
            Console.WriteLine(a + "]");
            return wynik;
        }
        static void Main(string[] args)
        {
            ZwrocPalindromy("[].]34Ala]/]'/Ma]]]ma]'/]KotA]/'/]");
            Console.ReadKey();
        }
    }
}
