using System;
//Aby upewnić się, że generowanie masek działa poprawnie, wyświetl je na ekran. 
//Stwórz funkcję string ZwrocMaskeJakoTekst1(uint n) , która wyświetli na ekran 
//maskę posiadającą na bicie n wartość 1, a na pozostałych bitach: 0.
namespace Zadanie_8._08
{
    class Program
    {
        static string ZwrocMaskeJakoTekst1(uint n)
        {
            string wynik = "";
            uint max = 1u << (int)n;
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
            Console.WriteLine(ZwrocMaskeJakoTekst1(2));
            Console.ReadKey();
        }
    }
}
