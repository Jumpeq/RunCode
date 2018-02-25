using System;
//Stwórz funkcję long[] Scal(long[] T1, long[] T2) , która zwróci tablicę 
//o elementach uporządkowanych niemalejąco, z dwóch tablic o elementach
//uporządkowanych rosnąco.Rozmiar zwracanej tablicy ma być równy sumie 
//rozmiarów tablic T1 oraz T2.
namespace Zadanie_6._10
{
    class Program
    {
        static long[] Scal(long[] T1, long[] T2)
        {
            int i, j, k;
            long[] wynik = new long[T1.Length + T2.Length];
            for (i = j = k = 0; i < T1.Length && j < T2.Length; k++)
            {
                if (T1[i] < T2[j])
                {
                    wynik[k] = T1[i];
                    i++;
                }
                else
                {
                    wynik[k] = T2[j];
                    j++;
                }
            }
            if (i < T1.Length)
            {
                while (T1.Length > i)
                {
                    wynik[k++] = T1[i++];
                }
            }
            else
            {
                while (T2.Length > j)
                {
                    wynik[k++] = T2[j++];
                }
            }
            for (int m = 0; m < wynik.Length; m++)
            {
                Console.Write("{0} ", wynik[m]);
            }
            return wynik;
        }
        static void Main(string[] args)
        {
            long[] tab = { 2, 3, 4, 4, 4, 5, 23 };
            long[] tab2 = { 1, 1, 2, 3, 7, 8, 63 };
            Scal(tab, tab2);
            Console.ReadKey();
        }
    }
}
