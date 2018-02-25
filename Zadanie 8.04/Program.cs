using System;
//Chcesz dokonywać operacji bitowych na liczbach dodatnich. Podobnie jak w 
//poprzednim zadaniu, przygotuj odpowiednią maskę. Pamiętaj o konwersji typów. 
//Stwórz funkcję uint PrzesunWLewo2(uint n) , która zwróci liczbę 1, po 
//przesunięciu o n bitów w lewo.
namespace Zadanie_8._04
{
    class Program
    {
        static uint PrzesunWLewo2(uint n)
        {
            int tmp = 1;
            tmp <<= Convert.ToInt32(n);
            return Convert.ToUInt32(tmp);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(PrzesunWLewo2(2));
            Console.ReadKey();
        }
    }
}
