using System;
//Stwórz funkcję string ZamienNaDwojkowy(uint n) , która z wykorzystaniem pętli obliczy
//i zwróci liczbę n (systemu dziesiętnego) w systemie dwójkowym (bez zer wiodących).

namespace Zadanie_4._03
{
    class Program
    {
        static string ZamienNaDwojkowy(uint n)
        {
            string wynik = "";
            if (n == 0)
            {
                return "0";
            }
            else
            {
                while (n > 0)
                {
                    if (n % 2 == 0)
                    {
                        wynik += "0";
                        n = n / 2;
                    }
                    else
                    {
                        wynik += "1";
                        n = n / 2;
                    }
                }
            }
            string wynik2 = "";
            for (int i = wynik.Length - 1; i >= 0; i--)
            {
                wynik2 += wynik[i];
            }
            return wynik2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ZamienNaDwojkowy(2));
            Console.ReadKey();
        }
    }
}
