using System;
//Stwórz funkcję bool CzyIstnieje(string napis, char a) , która zwraca true, 
//jeśli w tekście napis znajduje się znak a przesłany jako argument funkcji.
//W przeciwnym wypadku funkcja zwraca false.
namespace Zadanie_7._01
{
    class Program
    {
        static bool CzyIstnieje(string napis, char a)
        {
            for (int i = 0; i < napis.Length; i++)
            {
                if (napis[i] == a)
                {
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CzyIstnieje("blabla", 'e'));
            Console.ReadKey();
        }
    }
}
