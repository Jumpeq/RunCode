using System;
//Stwórz funkcję: bool CzyWKolejnosci(char a, char b, char c) Funkcja zwraca 
//true, jeśli wszystkie znaki przesłane jako argumenty funkcji są 
//literami(z ograniczeniem do liter alfabetu łacińskiego) uporządkowanymi 
//w kolejności rosnącej(np.: aBc; DeF). W innym przypadku 
//funkcja zwraca false.
namespace Zadanie_2._10
{
    class Program
    {
        static char ZamienNaMale(char a)
        {
            char x = (char)('a' - 'A');
            var y = 'Z' - a;
            if (y >= 0)
            {
                a += x;
            }
            return a;
        }
        static bool CzyWKolejnosci(char a, char b, char c)
        {
            a = ZamienNaMale(a);
            b = ZamienNaMale(b);
            c = ZamienNaMale(c);

            if (b == a + 1 && c == b + 1)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CzyWKolejnosci('D', 'e', 'F'));
            Console.ReadKey();
        }
    }
}
