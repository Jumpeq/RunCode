using System;
//Aby móc operować na wielu bitach jednocześnie, naucz się generowania masek 
//w formacie: 11100, 11111000, itp. Aby otrzymać maskę 11100, należy liczbę 
//7 (dwójkowo: 111), przesunąć o dwa bity w lewo. Stwórz funkcję string 
//ZwrocMaskeJakoTekst3(uint n) , która wygeneruje odpowiednią maskę 
//umożliwiającą dokonywanie operacji na trzech kolejnych bitach jednocześnie. 
//Liczba n przesłana w parametrze funkcji określa, o ile bitów w lewo przesunąć maskę.
namespace Zadanie_8._12
{
    class Program
    {
        static string ZwrocMaskeJakoTekst3(uint n)
        {
            string wynik = "";
            uint max = 7u << (int)n;
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
            Console.WriteLine(ZwrocMaskeJakoTekst3(7));
            Console.ReadKey();
        }
    }
}
