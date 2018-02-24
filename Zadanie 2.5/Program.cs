using System;
//Stwórz funkcję: double Funkcja1(int a, int b, int c) Funkcja oblicza 
//i zwraca wartość wyrażenia: (a+2b-5c)/ac , jeśli każda z liczb a, b i c
//jest nieujemna. Jeśli warunek nieujemności nie jest spełniony, funkcja 
//zwraca wartość -1.
namespace Zadanie_2._5
{
    class Program
    {
        static double Funkcja1(int a, int b, int c)
        {
            if (a >= 0 && b >= 0 && c >= 0)
            {
                if (a == 0 || c == 0)
                {
                    throw new Exception("You can't divide by zero!");
                }
                return ((double)(a + 2 * b - 5 * c)) / (a * c);
            }
            return -1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Funkcja1(21, 0, 2));
            Console.ReadKey();
        }
    }
}
