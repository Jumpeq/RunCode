using System;
//Stwórz funkcję: bool ZwrocPrzeciwne(bool a) Funkcja zwraca zaprzeczenie
//wartości logicznej a, przesłanej jako argument funkcji. Uwaga!
//Nie korzystaj z instrukcji warunkowej. Wykorzystaj odpowiedni operator.
namespace Zadanie_1._4
{
    class Program
    {
        static bool ZwrocPrzeciwne(bool a)
        {
            return !a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ZwrocPrzeciwne(true));
            Console.ReadKey();
        }
    }
}
