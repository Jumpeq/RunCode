using System;
//Stwórz funkcję: int ZwrocMax(int a, int b, int c) Funkcja zwraca 
//największą spośród liczb przesłanych jako argumenty funkcji.
namespace Zadanie_2._6
{
    class Program
    {
        static int ZwrocMax(int a, int b, int c)
        {
            var max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            return max;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ZwrocMax(2,1,5));
            Console.ReadKey();
        }
    }
}
