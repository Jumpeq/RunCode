using System;
//Stwórz funkcję int SumaA(int a, int b) , która zwróci sumę liczb całkowitych 
//większych od a i mniejszych od b, obliczoną z wykorzystaniem pętli.
namespace Zadanie_4._01
{
    class Program
    {
        static int SumaA(int a, int b)
        {
            int x = a + 1;
            int suma = 0;

            while (x < b)
            {
                suma += x;
                x += 1;
            }
            return suma;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SumaA(-5, -3));
            Console.ReadKey();
        }
    }
}
