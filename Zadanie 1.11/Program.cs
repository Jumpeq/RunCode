using System;
//Stwórz funkcję: double ObliczSrednia(int a, int b) Funkcja zwraca 
//średnią arytmetyczną z dwóch liczb, przesłanych jako argumenty funkcji.
namespace Zadanie_1._11
{
    class Program
    {
        static double ObliczSrednia(int a, int b)
        {
            return ((double)a + (double)b) / 2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ObliczSrednia(13,4));
            Console.ReadKey();
        }
    }
}
