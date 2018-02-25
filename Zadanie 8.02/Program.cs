using System;
//Masz do dyspozycji liczbę 2 (dwójkowo: 10) jako maskę. Potrzebujesz jednak innej
//maski: z czwartym bitem ustawionym na wartość 1 (dwójkowo: 10000). Dokonaj 
//przesunięcia maski o 3 bity w lewo. Stwórz funkcję int PrzesunWLewoO3() , która 
//zwróci liczbę 2 (dwójkowo: 10), po przesunięciu o 3 bity w lewo.
namespace Zadanie_8._02
{
    class Program
    {
        static int PrzesunWLewoO3()
        {
            int tmp = 2;
            tmp <<= 3;
            return tmp;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(PrzesunWLewoO3());
            Console.ReadKey();
        }
    }
}
