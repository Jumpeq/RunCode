using System;
//Stwórz funkcję int Suma1(int a, int b, int c) , która zwróci sumę kolejnych wyrazów 
//ciągu arytmetycznego o różnicy c, mniejszych od b, obliczoną z wykorzystaniem pętli. 
//Pierwszy wyraz ciągu: a.
namespace Zadanie_4._06
{
    class Program
    {
        static int Suma1(int a, int b, int c)
        {
            int suma = 0;
            while (a < b)
            {
                suma += a;
                a += c;
            }
            return suma;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Suma1(1, 4, 1));
            Console.ReadKey();
        }
    }
}
