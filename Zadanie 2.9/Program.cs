using System;
//Stwórz funkcję: bool CzyMalaLitera(char a, char b, char c) Funkcja zwraca
//true, jeśli co najmniej jeden ze znaków przesłanych jako argumenty funkcji
//jest małą literą (z ograniczeniem do liter alfabetu łacińskiego).
//W innym przypadku funkcja zwraca false.
namespace Zadanie_2._9
{
    class Program
    {
        static bool CzyMalaLitera(char a, char b, char c)
        {

            if (a - 'Z' > 0 || b - 'Z' > 0 || c - 'Z' > 0)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CzyMalaLitera('A', 'a', 'C'));
            Console.ReadKey();
        }
    }
}
