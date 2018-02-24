using System;
//Stwórz funkcję: bool CzyZero(int a) Funkcja zwraca wartość logiczną true, 
//jeśli liczba przesłana jako argument funkcji ma wartość 0. W innym 
//przypadku funkcja zwraca false.
namespace Zadanie_2._1
{
    class Program
    {
        static bool CzyZero(int a)
        {
            if (a == 0)
                return true;
            else return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CzyZero(0));
            Console.ReadKey();
        }
    }
}
