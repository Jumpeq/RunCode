using System;
//Stwórz funkcję int SumaWTablicy(int[] tab) , która zwróci wynik
//sumowania wszystkich liczb w tablicy tab.
namespace Zadanie_6._01
{
    class Program
    {
        static int SumaWTablicy(int[] tab)
        {
            int suma = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                suma += tab[i];
            }
            return suma;
        }
        static void Main(string[] args)
        {
            int[] tab = { 1, 2, 3, 4, 5 };
            Console.WriteLine(SumaWTablicy(tab));
            Console.ReadKey();
        }
    }
}
