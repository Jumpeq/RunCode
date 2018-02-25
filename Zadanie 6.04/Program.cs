using System;
//Stwórz funkcję decimal ElementMax(decimal[] tablica ) , która zwróci element 
//maksymalny z tablicy tablica.
namespace Zadanie_6._04
{
    class Program
    {
        static decimal ElementMax(decimal[] tablica)
        {
            decimal max = tablica[0];
            for (int i = 0; i < tablica.Length; i++)
            {
                if (max < tablica[i])
                    max = tablica[i];
            }
            return max;
        }
        static void Main(string[] args)
        {
            decimal[] a = { 1, 2, 3, 4 };
            Console.WriteLine(ElementMax(a));
            Console.ReadKey();
        }
    }
}
