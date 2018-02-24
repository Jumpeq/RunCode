using System;
//Stwórz funkcję: string DodajTeksty(string tekst1, string tekst2) Funkcja 
//zwraca tekst, będący wynikiem połączenia tekstów przesłanych jako
//argumenty funkcji, np. dla argumentów "progra" "mowanie", funkcja
//zwróci "programowanie".
namespace Zadanie_1._8
{
    class Program
    {
        static string DodajTeksty(string tekst1, string tekst2)
        {
            return tekst1 + tekst2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(DodajTeksty("progra","mowanie"));
            Console.ReadKey();
        }
    }
}
