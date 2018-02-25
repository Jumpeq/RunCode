using System;
//Stwórz funkcję bool CzyIstnieje1(int a, int b) , która zwraca true, jeśli 
//w przedziale obustronnie domkniętym [a;b] znajduje się liczba pierwsza. 
//W przeciwnym wypadku funkcja zwraca false.
namespace Zadanie_4._04
{
    class Program
    {
        static bool CzyIstnieje1(int a, int b)
        {
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
                        return true;
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
                        return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CzyIstnieje1(23, 26));
            Console.ReadKey();
        }
    }
}
