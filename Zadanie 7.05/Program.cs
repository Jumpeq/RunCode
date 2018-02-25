using System;
//Stwórz funkcję bool CzyAnagram(string napis1, string napis2) ,która sprawdza, czy 
//tekst napis1 jest anagramem tekstu napis2, ignorując wielkość liter (np. gniady 
//to anagram dla Gdynia). Należy zaimplementować własny algorytm, nie korzystając 
//z funkcji klasy string (np. Split, Contains, etc.). W tekście znajdują się tylko litery.
namespace Zadanie_7._05
{
    class Program
    {
        static bool CzyAnagram(string napis1, string napis2)
        {
            if (napis1.Length != napis2.Length) return false;
            string nap1 = "";
            for (int i = 0; i < napis1.Length; i++)
            {
                if (napis1[i] >= 'A' && napis1[i] <= 'Z')
                {
                    nap1 += Convert.ToChar(napis1[i] + ('a' - 'A'));
                }
                else
                {
                    nap1 += napis1[i];
                }
            }
            string nap2 = "";
            for (int i = 0; i < napis2.Length; i++)
            {
                if (napis2[i] >= 'A' && napis2[i] <= 'Z')
                {
                    nap2 += Convert.ToChar(napis2[i] + ('a' - 'A'));
                }
                else
                {
                    nap2 += napis2[i];
                }
            }

            int n1 = nap1.Length;
            char[] tab1 = new char[nap1.Length];
            for (int i = 0; i < tab1.Length; i++)
            {
                tab1[i] = nap1[i];
            }
            while (n1 > 0)
            {
                for (int i = 0; i < n1 - 1; i++)
                {
                    if (tab1[i] > tab1[i + 1])
                    {
                        int tmp = tab1[i];
                        tab1[i] = tab1[i + 1];
                        tab1[i + 1] = (char)tmp;
                    }
                }
                n1--;
            }
            string wynik1 = new string(tab1);

            int n2 = nap2.Length;
            char[] tab2 = new char[nap2.Length];
            for (int i = 0; i < tab2.Length; i++)
            {
                tab2[i] = nap2[i];
            }
            while (n2 > 0)
            {
                for (int i = 0; i < n2 - 1; i++)
                {
                    if (tab2[i] > tab2[i + 1])
                    {
                        int tmp = tab2[i];
                        tab2[i] = tab2[i + 1];
                        tab2[i + 1] = (char)tmp;
                    }
                }
                n2--;
            }
            string wynik2 = new string(tab2);
            for (int i = 0; i < napis1.Length; i++)
            {
                if (wynik1[i] != wynik2[i]) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CzyAnagram("gniaoy", "Gdynia"));
            Console.ReadKey();
        }
    }
}
