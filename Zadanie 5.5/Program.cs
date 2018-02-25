using System;
//Stwórz funkcję double Pomnoz1(double[] tab, int i=0) , która zwraca wynik
//mnożenia wszystkich liczb w tablicy wykorzystując rekurencję.
namespace Zadanie_5._5
{
    class Program
    {
        public static double Pomnoz1(double[] tab, int i = 0)
        {
            if (i == tab.Length)
                return 0;
            double b = Pomnoz1(tab, i + 1);
            if (b == 0)
                return tab[i];
            return tab[i] * b;
        }
        static void Main(string[] args)
        {
            double[] T2 = { 9, 3, 2, 3, 4, 4, 6, 7, 1 };
            Console.WriteLine(Pomnoz1(T2));
            Console.ReadKey();
        }
    }
}
