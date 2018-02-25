using System;
//Chcesz tworzyć dowolne maski w formacie: 10000, 10, 10000000, itp. Przesuń liczbę 
//1 w lewo, aby uzyskać żądany efekt. Stwórz funkcję int PrzesunWLewo1(int n) , 
//która zwróci liczbę 1, po przesunięciu o n bitów w lewo.
namespace Zadanie_8._03
{
    class Program
    {
        static int PrzesunWLewo1(int n)
        {
            int tmp = 1;
            tmp <<= n;
            return tmp;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(PrzesunWLewo1(2));
            Console.ReadKey();
        }
    }
}
