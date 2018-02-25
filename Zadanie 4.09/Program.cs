using System;
//Stwórz funkcję double Srednia1(int a, int n) , która obliczy z wykorzystaniem pętli 
//średnią arytmetyczną tych liczb całkowitych większych niż a, które są większe
//maksymalnie o n od a, i jednocześnie spełniają następujące warunki: są niepodzielne 
//przez 3 i niepodzielne przez 5.
namespace Zadanie_4._09
{
    class Program
    {
        static double Srednia1(int a, int n)
        {
            double srednia = 0;
            uint ile = 0;
            for (int i = a + 1; i <= a + n; i++)
            {
                if (i % 3 != 0 && i % 5 != 0)
                {
                    srednia += i;
                    ile++;
                }
            }
            return srednia / ile;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Srednia1(4, 8));
            Console.ReadKey();
        }
    }
}
