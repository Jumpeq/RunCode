using System;
//Aby móc przetestować poprawność działania masek, wyświetlaj liczby 
//w postaci binarnej. Stwórz funkcję string ZwrocBinarnie2(int liczba) 
//, która z wykorzystaniem operatora & oraz >> wygeneruje zapis dwójkowy 
//dowolnej liczby systemu dziesiętnego.
namespace Zadanie_8._11
{
    class Program
    {
        static string ZwrocBinarnie2(int liczba)
        {
            if (liczba == 0)
                return "0";
            string wynik = "";
            if (liczba > 0)
            {
                while (liczba > 0)
                {
                    if ((liczba & 1) == 1)
                    {
                        wynik += '1';
                    }
                    if ((liczba & 1) == 0)
                    {
                        wynik += '0';
                    }
                    liczba >>= 1;
                }
            }
            else
            {
                int i = 32;
                while (i > 0)
                {
                    if ((liczba & 1) == 1)
                    {
                        wynik += '1';
                    }
                    if ((liczba & 1) == 0)
                    {
                        wynik += '0';
                    }
                    liczba >>= 1;
                    i--;
                }
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
            Console.WriteLine(ZwrocBinarnie2(2));
            Console.ReadKey();
        }
    }
}
