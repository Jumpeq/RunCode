using System;
//Stwórz funkcję: int ZwrocPodwojne(int a) Funkcja zwraca podwojoną wartość 
//liczby a, przesłanej jako argument funkcji.
namespace Zadanie_1._2
{
    class Program
    {
        static int ZwrocPodwojne(int a)
        {
            return 2 * a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ZwrocPodwojne(4));
            Console.ReadKey();
        }
    }
}
