using System;
//Stwórz funkcję: uint ZwrocLiczbe(uint setki, uint dziesiatki, 
//uint jednosci) Funkcja zwraca liczbę obliczoną na podstawie podanych: 
//liczby setek, dziesiątek oraz jedności (np. dla argumentów 3, 7, 2, 
//funkcja powinna zwrócić liczbę: 372).
namespace Zadanie_1._6
{
    class Program
    {
        static uint ZwrocLiczbe(uint setki, uint dziesiatki, uint jednosci)
        {
            return Convert.ToUInt16(String.Format("{0}{1}{2}", setki, dziesiatki, jednosci));
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ZwrocLiczbe(3,7,2));
            Console.ReadKey();
        }
    }
}
