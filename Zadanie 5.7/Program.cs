using System;
//Stwórz funkcję double Pomnoz3(double[] tab, int i=0) , która zwraca wynik 
//mnożenia wszystkich liczb w tablicy na indeksach niepodzielnych przez 3.
namespace Zadanie_5._7
{
    class Program
    {
        public static double Pomnoz3(double[] tab, int i = 0)
        {
            if (i == tab.Length)
                return 0;
            double b = Pomnoz3(tab, i + 1);
            if (i % 3 == 0)
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
            Console.WriteLine(Pomnoz3(T2));
            Console.ReadKey();
        }
    }
}
