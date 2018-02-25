using System;
//Stwórz funkcję int IloczynPodzielnych(int[] tab) , która zwróci wynik mnożenia
//wszystkich liczb z tablicy, które są podzielne przez 3.
namespace Zadanie_6._02
{
    class Program
    {
        static int IloczynPodzielnych(int[] tab)
        {
            int iloczyn = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] % 3 == 0)
                {
                    if (iloczyn == 0)
                    {
                        iloczyn = 1;
                        iloczyn *= tab[i];
                    }
                    else
                    {
                        iloczyn *= tab[i];
                    }
                }
            }
            return iloczyn;
        }
        static void Main(string[] args)
        {
            int[] tab = { 1, 2, 3, 4 };
            Console.WriteLine(IloczynPodzielnych(tab));
            Console.ReadKey();
        }
    }
}
