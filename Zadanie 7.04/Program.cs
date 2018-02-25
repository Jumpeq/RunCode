using System;
//Stwórz funkcję bool CzyUporzadkowany(string napis) , która zwraca true, jeśli 
//litery w tekście napis są umieszczone w porządku alfabetycznym 
//(rosnąco lub malejąco). Tekst zawiera tylko litery.
namespace Zadanie_7._04
{
    class Program
    {
        static string ZamienNaMale(string napis)
        {
            string zwr = "";
            int roznica = 'a' - 'A';
            for (int i = 0; i < napis.Length; i++)
            {
                if (napis[i] >= 65 && napis[i] <= 90)
                {
                    zwr += (char)(napis[i] + roznica);
                }
                else
                {
                    zwr += napis[i];
                }
            }
            return zwr;
        }
        static bool CzyUporzadkowany(string napis)
        {
            int i = 0;
            var txt = ZamienNaMale(napis);
            while (i < txt.Length - 1)
            {
                if (txt[i] > txt[i + 1])
                {
                    return false;
                }
                i += 1;
            }
            if (txt.Length <= 0)
                return false;
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CzyUporzadkowany("aabf"));
            Console.ReadKey();
        }
    }
}
