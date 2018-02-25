using System;
//Aby móc przetestować poprawność działania masek, wyświetlaj liczby 
//w postaci binarnej. Stwórz funkcję string ZwrocBinarnie1(uint liczba) 
//, która z wykorzystaniem operatora & oraz >> wygeneruje zapis dwójkowy 
//dodatniej liczby systemu dziesiętnego.
namespace Zadanie_8._10
{
    class Program
    {
        static string ZwrocBinarnie1(uint liczba)
        {
            if (liczba == 0)
                return "0";
            string wynik = "";
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
            char[] charArr = new char[wynik.Length];
            for (int i = wynik.Length - 1; i >= 0; i--)
            {
                charArr[wynik.Length - 1 - i] = wynik[i];
            }
            return new string(charArr);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ZwrocBinarnie1(4));
            Console.ReadKey();
        }
    }
}
