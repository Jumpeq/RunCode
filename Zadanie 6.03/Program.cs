using System;
//Stwórz funkcję decimal IloczynNiepodzielnych(decimal[] T) , która zwróci wynik
//mnożenia tych elementów z tablicy T, które znajdują się na indeksach w tablicy
//spełniających jednocześnie dwa warunki: są nieparzyste i niepodzielne przez 3.
namespace Zadanie_6._03
{
    class Program
    {
        static decimal IloczynNiepodzielnych(decimal[] T)
        {
            decimal iloczyn = 0;

            for (int i = 0; i < T.Length; i++)
            {
                if (i % 2 != 0 && i % 3 != 0)
                {
                    if (iloczyn == 0)
                        iloczyn = 1;
                    iloczyn *= T[i];
                }
            }
            return iloczyn;
        }
        static void Main(string[] args)
        {
            decimal[] tab = { 1, 2, 3, 4 };
            Console.WriteLine(IloczynNiepodzielnych(tab));
            Console.ReadKey();
        }
    }
}
