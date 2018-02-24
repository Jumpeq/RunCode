using System;
//Stwórz funkcję: bool CzyDodINiepodzPrzez3(int a, int b, int c) Funkcja 
//zwraca wartość logiczną true, jeśli co najmniej jedna z liczb przesłanych 
//jako argument funkcji jest dodatnia i jednocześnie niepodzielna przez 3.
//W innym przypadku funkcja zwraca false.
namespace Zadanie_2._3
{
    class Program
    {
        static bool CzyDodINiepodzPrzez3(int a, int b, int c)
        {
            if ((a > 0 && a % 2 != 0) || (b > 0 && b % 2 != 0) || (c > 0 && c % 2 != 0))
                return true;
            else return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CzyDodINiepodzPrzez3(0,-2,3));
            Console.ReadKey();
        }
    }
}
