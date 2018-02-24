using System;
//Stwórz funkcję: bool ZwrocIloczyn(bool a, bool b) Funkcja zwraca 
//wartość iloczynu logicznego a i b, przesłanych jako argument funkcji.
namespace Zadanie_1._5
{
    class Program
    {
        static bool ZwrocIloczyn(bool a, bool b)
        {
            return a && b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ZwrocIloczyn(false, false));
            Console.ReadKey();
        }
    }
}
