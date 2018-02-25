using System;
//Chcesz sprawdzić, jaką ma wartość najmłodszy (zerowy) bit liczby. Skorzystaj 
//z maski 1 (dwójkowo: 1) oraz operacji &. Maska na bicie zerowym ma 1, na
//pozostałych bitach 0, więc wykorzystana z operatorem & pozwoli na zwrócenie 
//odpowiedniej wartości. Stwórz funkcję uint JakiBit(uint liczba) , która 
//wykorzystując maskę 1 zwróci wartość zerowego bitu liczby przesłanej 
//w parametrze funkcji.
namespace Zadanie_8._07
{
    class Program
    {
        static uint JakiBit(uint liczba)
        {
            uint mask = 1;
            return liczba & mask;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(JakiBit(5));
            Console.ReadKey();
        }
    }
}
