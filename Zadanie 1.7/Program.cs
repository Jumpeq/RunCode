using System;
//Stwórz funkcję: string ZwrocLiczbeJakoTekst(uint setki, uint dziesiatki,
//uint jednosci) Funkcja zwraca tekst zawierający liczbę obliczoną 
//na podstawie podanych: liczby setek, dziesiątek oraz jedności 
//(np. dla argumentów 3, 7, 2, funkcja powinna zwrócić tekst: 372).
namespace Zadanie_1._7
{
    class Program
    {
        static string ZwrocLiczbeJakoTekst(uint setki, uint dziesiatki, uint jednosci)
        {
            return String.Format("{0}{1}{2}", setki, dziesiatki, jednosci);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ZwrocLiczbeJakoTekst(3,7,2));
            Console.ReadKey();
        }
    }
}
