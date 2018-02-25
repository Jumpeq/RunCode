using System;
//Stwórz funkcję: uint IleJedynek(uint n) Funkcja rekurencyjnie oblicza, ile
//jest jedynek w zapisie dwójkowym liczby n.
namespace Zadanie_3._10
{
    class Program
    {
        static uint IleJedynek(uint n)
        {
            if (n == 0) return 0;
            if (n % 2 == 1) return 1 + IleJedynek(n / 2);
            else return 0 + IleJedynek(n / 2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IleJedynek(0));
            Console.ReadKey();
        }
    }
}
