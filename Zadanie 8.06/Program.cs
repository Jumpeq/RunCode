using System;
//Aby zmienić wartość bitu n z 1 na 0, potrzebujesz operacji & oraz 
//odpowiedniej maski. Stwórz funkcję uint ZwrocMaske2(uint n) , która 
//przygotuje maskę posiadającą na bicie n wartość 0, a na pozostałych bitach: 1.
namespace Zadanie_8._06
{
    class Program
    {
        static uint ZwrocMaske2(uint n)
        {
            uint tmp = (uint)Math.Pow(2, n);
            uint max = uint.MaxValue;
            uint sprawdz = max - tmp;
            return max & sprawdz;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ZwrocMaske2(2));
            Console.ReadKey();
        }
    }
}
