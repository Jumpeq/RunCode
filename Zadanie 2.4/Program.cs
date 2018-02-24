using System;
//Stwórz funkcję: uint IlePierwiastkow(double a, double b, double c) Funkcja
//oblicza i zwraca liczbę pierwiastków rzeczywistych równania kwadratowego
//postaci ax^2 + bx + c = 0, dla współczynników przesłanych jako argumenty 
//funkcji.
namespace Zadanie_2._4
{
    class Program
    {
        static uint IlePierwiastkow(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;
            if (delta > 0)
                return 2;
            else if (delta == 0)
                return 1;
            else
                return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IlePierwiastkow(2,5,2));
            Console.ReadKey();
        }
    }
}
