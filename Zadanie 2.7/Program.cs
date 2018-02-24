using System;
//Stwórz funkcję: double ObliczSrednia(int x, int y, int z) Funkcja znajduje
//największą(max) oraz najmniejszą(min) spośród liczb przesłanych jako 
//argumenty funkcji i zwraca średnią arytmetyczną liczb max i min.
namespace Zadanie_2._7
{
    class Program
    {
        static double ObliczSrednia(int x, int y, int z)
        {
            var max = x;
            var min = x;
            if (y > max) max = y;            
            if (z > max) max = z;            
            if (y < min) min = y;            
            if (z < min) min = z;            
            return ((double)max + min) / 2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ObliczSrednia(2, 2, 5));
            Console.ReadKey();
        }
    }
}
