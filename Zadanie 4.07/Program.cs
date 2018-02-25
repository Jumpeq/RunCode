using System;
//Stwórz funkcję int Suma2(int a, int n) , która z wykorzystaniem pętli obliczy
//i zwróci sumę tych spośród n kolejnych liczb większych od a, które jednocześnie 
//spełniają następujące warunki: są podzielne przez 5 oraz niepodzielne przez 7.

namespace Zadanie_4._07
{
    class Program
    {
        static int Suma2(int a, int n)
        {
            int suma = 0;
            for (int i = a + 1; i <= a + n; i++)
            {
                if (i % 5 == 0 && i % 7 != 0)
                    suma += i;
            }
            return suma;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Suma2(1, 6));
            Console.ReadKey();
        }
    }
}
