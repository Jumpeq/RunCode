using System;
//Stwórz funkcję: bool CzyDodatniaINieparzysta(int a) Funkcja zwraca wartość
//logiczną true, jeśli liczba przesłana jako argument funkcji jest dodatnia
//i jednocześnie nieparzysta. W innym przypadku funkcja zwraca false.
namespace Zadanie_2._2
{
    class Program
    {
        static bool CzyDodatniaINieparzysta(int a)
        {
            if (a > 0 && a % 2 != 0)
                return true;
            else return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CzyDodatniaINieparzysta(3));
            Console.ReadKey();
        }
    }
}
