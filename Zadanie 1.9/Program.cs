using System;
//Stwórz funkcję: uint DodajLiterki(char a, char b) Funkcja zwraca liczbę,
//będącą wynikiem dodawania wartości kodu znaków przesłanych
//jako argumenty funkcji (kod znaku 'a' to 97).
namespace Zadanie_1._9
{
    class Program
    {
        static uint DodajLiterki(char a, char b)
        {
            return Convert.ToUInt32(a + b);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(DodajLiterki('a','a'));
            Console.ReadKey();
        }
    }
}
