using System;
//Stwórz funkcję bool CzyIstnieje2(int a, int b) , która zwraca true, jeśli 
//w przedziale obustronnie domkniętym [a;b] znajdują się dokładnie dwie 
//liczby pierwsze.
namespace Zadanie_4._05
{
    class Program
    {
        static bool CzyIstnieje2(int a, int b)
        {
            int ile = 0;
            if (b <= 0)
                return false;
            if (a <= 0 && b > 0)
            {
                int licznik = 0;
                for (int i = 0; i <= b; i++)
                {
                    licznik = 0;
                    for (int j = 2; j <= i; j++)
                    {
                        if (i % j == 0)
                            licznik++;
                    }
                    if (licznik == 1)
                    {
                        ile++;
                    }
                }
            }
            if (a > 0)
            {
                int licznik = 0;
                for (int i = a; i <= b; i++)
                {
                    licznik = 0;
                    for (int j = 2; j <= i; j++)
                    {
                        if (i % j == 0)
                            licznik++;
                    }
                    if (licznik == 1)
                        ile++;
                }
            }
            if (ile == 2)
                return true;
            else return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CzyIstnieje2(3, 7));
            Console.ReadKey();
        }
    }
}
