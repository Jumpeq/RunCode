using System;
//Stwórz funkcję double Pomnoz2(double[] tab, int i=0) , która zwraca wynik 
//mnożenia wszystkich liczb w tablicy podzielnych przez 7 lub 3 wykorzystując 
//rekurencję.
namespace Zadanie_5._6
{
    class Program
    {
        public static double Pomnoz2(double[] tab, int i = 0)
        {
            if (i == tab.Length)
                return 0;
            double b = Pomnoz2(tab, i + 1);
            if (tab[i] % 3 == 0 || tab[i] % 7 == 0)
            {
                if (b == 0)
                    return tab[i];
                return tab[i] * b;
            }
            return b;
        }
        static void Main(string[] args)
        {
            double[] T2 = { 9, 3, 2, 3, 4, 4, 6, 7, 1 };
            Console.WriteLine(Pomnoz2(T2));
            Console.ReadKey();
        }
    }
}
