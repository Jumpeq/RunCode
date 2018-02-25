using System;
//Aby zmienić wartość bitu n z 0 na 1, potrzebujesz operacji | oraz 
//odpowiedniej maski. Stwórz funkcję uint ZwrocMaske1(uint n) , która 
//przygotuje maskę posiadającą na bicie n wartość 1, a na pozostałych bitach: 0.
namespace Zadanie_8._05
{
    class Program
    {
        static uint ZwrocMaske1(uint n)
        {
            //do czego służy | w tym zadaniu?
            uint tmp = 0;
            tmp = tmp | (uint)Math.Pow(2, n);
            return tmp;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ZwrocMaske1(3));
            Console.ReadKey();
        }
    }
}
