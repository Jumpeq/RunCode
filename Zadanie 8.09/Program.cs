using System;
//Stwórz funkcję string ZwrocMaskeJakoTekst2(uint bit) , która wyświetli na ekran 
//maskę posiadającą na bicie n wartość 0, a na pozostałych bitach: 1.
namespace Zadanie_8._09
{
    class Program
    {
        static string ZwrocMaskeJakoTekst2(uint bit)
        {
            string wynik = "";
            uint max = UInt32.MaxValue;
            max = max - (uint)Math.Pow(2, bit);
            while (max > 0)
            {
                if (max % 2 == 1)
                {
                    wynik += "1";
                }
                if (max % 2 == 0)
                {
                    wynik += "0";
                }
                max /= 2;
            }
            char[] charArr = new char[wynik.Length];
            for (int i = wynik.Length - 1; i >= 0; i--)
            {
                charArr[wynik.Length - 1 - i] = wynik[i];
            }
            return new string(charArr);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ZwrocMaskeJakoTekst2(2));
            Console.ReadKey();
        }
    }
}
