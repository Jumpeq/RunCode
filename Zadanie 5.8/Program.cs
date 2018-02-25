using System;
//Stwórz funkcję bool CzyJest(int[] tab, int n, int i=0) , która działa 
//rekurencyjnie i zwraca true, jeśli w tablicy znajduje się liczba podzielna przez n.
namespace Zadanie_5._8
{
    class Program
    {
        public static bool CzyJest(int[] tab, int liczba, int i = 0)
        {
            if (i == tab.Length)
                return false;
            if (tab[i] == liczba)
                return true;
            return CzyJest(tab, liczba, i + 1);
        }
        static void Main(string[] args)
        {
            int[] T1 = { 0, 1, 4, 3, 4, 7, 6, 7, 9 };
            Console.WriteLine(CzyJest(T1, 7));
            Console.ReadKey();
        }
    }
}
