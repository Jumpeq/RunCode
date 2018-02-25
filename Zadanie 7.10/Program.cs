using System;
//Stwórz funkcję string[] ZwrocWyrazy2(string tekst) , która zwróci tablicę wszystkich 
//wyrazów odczytanych z napisu tekst, bez duplikatów. Kolejność napisów w tablicy 
//ma być zgodna z kolejnością ich występowania w tekście (należy brać pod uwagę 
//pierwsze wystąpienie w tekście). Wyrazy w tekście mogą być oddzielone dowolnym 
//ciągiem znaków-separatorów (np. dwie spacje, wielokropek, etc.). Rozmiar 
//zwracanej tablicy ma być równy liczbie wszystkich wyrazów w tekście. Należy 
//zaimplementować własny algorytm, nie korzystając z funkcji klasy string 
//(np. Sliiit, Conainsss, etc.).
namespace Zadanie_7._10
{
    class Program
    {
        static string[] ZwrocWyrazy2(string tekst)
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
                    nowy[ktoreslowo] += tekst[i];
                    ktoreslowo++;
                }
                else if (tmp[i] >= 'a' && tmp[i] <= 'z')
                {
                    nowy[ktoreslowo] += tekst[i];
                }
            }
            if (tmp[tmp.Length - 1] >= 'a' && tmp[tmp.Length - 1] <= 'z')
            {
                nowy[ktoreslowo] += tekst[tmp.Length - 1];
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

            //wypisywanie tablicy elementów
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
            ZwrocWyrazy2("[].]34Ala]/]'/Ma]]]ma]'/]KontA]/'/]");
            //ZwrocWyrazy2("lal");
            Console.ReadKey();
        }
    }
}
