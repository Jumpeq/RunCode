using System;
//Aby móc operować na wielu bitach jednocześnie, naucz się generowania masek 
//w formacie: 111111110011, 11111000111, itp. Aby otrzymać maskę 
//typu: 11111111111110011, należy liczbę 3 (dwójkowo: 11), przesunąć o dwa bity 
//w lewo i wykonać operację negacji. Stwórz funkcję 
//string ZwrocMaskeOdwJakoTekst(uint n) , która wygeneruje odpowiednią maskę 
//umożliwiającą dokonywanie operacji na dwóch kolejnych bitach jednocześnie.
//Liczba n przesłana w parametrze funkcji określa, o ile bitów w lewo 
//przesunąć maskę.
namespace Zadanie_8._13
{
    class Program
    {
        static string ZwrocMaskeOdwJakoTekst(uint n)
        {
            string wynik = "";
            uint max = 3u << (int)n;
            max = ~max;
            //max |= (7u << n);
            while (max > 0)
            {
                if (max % 2 == 0)
                {
                    wynik = "0" + wynik;
                }
                if (max % 2 == 1)
                {
                    wynik = "1" + wynik;
                }
                max /= 2;
            }
            return wynik;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(ZwrocMaskeOdwJakoTekst(3));
            Console.ReadKey();
        }
    }
}
