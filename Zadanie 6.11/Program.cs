using System;
//Stwórz funkcję bool CzyIstniejaLiczby(int[] T) , która zwraca true, jeśli 
//w tablicy T można wybrać takie trzy liczby (na różnych indeksach), których 
//suma jest liczbą pierwszą. W przeciwnym wypadku funkcja zwraca false.
namespace Zadanie_6._11
{
    class Program
    {
        static bool CzyIstniejaLiczby(int[] T)
        {
            int tmp;
            for (int i = 0; i < T.Length - 2; i++)
            {
                for (int j = i + 1; j < T.Length - 1; j++)
                {
                    for (int k = j + 1; k < T.Length; k++)
                    {
                        tmp = T[i] + T[j] + T[k];
                        if (tmp > 1)
                        {
                            int s = 0;
                            for (int d = 2; d <= tmp; d++)
                            {
                                if (tmp % d == 0)
                                    s++;
                            }
                            if (s == 1)
                                return true;
                        }
                    }
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            int[] tab = { 1, 2, 5, 5, 5, 5 };
            Console.WriteLine(CzyIstniejaLiczby(tab));
            Console.ReadKey();
        }
    }
}
