using System;
//Stwórz funkcję int[] Uporzadkuj(int[] T) , która uporządkuje elementy tablicy 
//T i zwróci tablicę uporządkowaną w następującym porządku: elementy na indeksach
//nieparzystych z tablicy T należy uporządkować niemalejąco w zwracanej tablicy,
//a elementy na pozostałych indeksach należy uporządkować nierosnąco
namespace Zadanie_6._12
{
    class Program
    {
        static int[] Uporzadkuj(int[] T)
        {
            int pom;
            for (int i = 0; i < T.Length; i++)
            {
                for (int j = i; j < T.Length; j++)
                {
                    if (i % 2 != 0 && j % 2 != 0)
                    {
                        if (T[i] > T[j])
                        {
                            pom = T[i];
                            T[i] = T[j];
                            T[j] = pom;

                        }
                    }
                    if (i % 2 == 0 && j % 2 == 0)
                    {
                        if (T[i] < T[j])
                        {
                            pom = T[i];
                            T[i] = T[j];
                            T[j] = pom;
                        }
                    }
                }
            }
            string a = "[";
            if (T.Length > 0)
            {
                a += T[0];
                for (int i = 1; i < T.Length; i++)
                    a += ", " + T[i];
            }
            Console.WriteLine(a + "]");
            return T;
        }
        static void Main(string[] args)
        {
            int[] tab = { 5, 11, 15, 18, 23, 10, 9 };
            Uporzadkuj(tab);
            Console.ReadKey();
        }
    }
}
