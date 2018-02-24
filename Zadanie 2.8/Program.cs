using System;
//Stwórz funkcję: bool CzyNiemalejace(int a, int b, int c) Funkcja zwraca 
//true, jeśli liczby przesłane jako argumenty funkcji (w kolejności: a, b, c)
//tworzą ciąg niemalejący. W innym przypadku funkcja zwraca false.
namespace Zadanie_2._8
{
    class Program
    {
        static bool CzyNiemalejace(int a, int b, int c)
        {
            if (b >= a && c >= b)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CzyNiemalejace(1, 1, 2));
            Console.ReadKey();
        }
    }
}
