using System;
//Stwórz funkcję double[] Ujemne(double[] tab) , która zwraca tablicę zawierającą 
//tylko te liczby z tablicy tab, które są mniejsze od 0. Rozmiar zwracanej tablicy
//ma być równy liczbie znalezionych liczb spełniających warunki w tablicy tab.
namespace Zadanie_6._08
{
    class Program
    {
        public static double[] Ujemne(double[] tab)
        {
            int wynik = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] < 0)
                    wynik++;
            }
            double[] tabik = new double[wynik];
            wynik = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] < 0)
                {
                    tabik[wynik] = tab[i];
                    wynik++;
                }
            }
            string a = "[";
            if (tabik.Length > 0)
            {
                a += tabik[0];
                for (int i = 1; i < tabik.Length; i++)
                    a += ", " + tabik[i];
            }
            Console.WriteLine(a + "]");
            return tabik;
        }
        static void Main(string[] args)
        {
            double[] tab = { 1, -5, 45, 5, 3, -6 };
            int[] tab2 = { };
            Ujemne(tab);
            Console.ReadKey();
        }
    }
}
