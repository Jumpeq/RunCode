using System;
//Stwórz funkcję: string DodajLiterkiNaTekst(char a, char b, char c)
//Funkcja zwraca tekst, będący złączeniem znaków a, b i c, oddzielonych 
//spacją (np. dla argumentów 'a', 'l', 'a', funkcja zwraca tekst "a l a".
namespace Zadanie_1._10
{
    class Program
    {
        static string DodajLiterkiNaTekst(char a, char b, char c)
        {
            return a + " " + b + " " + c;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(DodajLiterkiNaTekst('a','l','a'));
            Console.ReadKey();
        }
    }
}
