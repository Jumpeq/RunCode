using System;
//Stwórz funkcję: int Pomnoz(int a, int b) Funkcja zwraca iloczyn
//liczb a i b.
namespace Zadanie_1._3
{
    class Program
    {
        static int Pomnoz(int a, int b)
        {
            return a * b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Pomnoz(2,6));
            Console.ReadKey();
        }
    }
}
