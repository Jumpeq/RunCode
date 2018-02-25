using System;
//Masz do dyspozycji liczbę 8 (dwójkowo: 1000) jako maskę. Potrzebujesz 
//jednak innej maski: z pierwszym bitem ustawionym na wartość 1 (dwójkowo: 10),
//a bitem zerowym na wartość 0. Dokonaj przesunięcia maski o 2 bity w prawo. 
//Stwórz funkcję int PrzesunWPrawoO2() , która zwróci liczbę 8 (dwójkowo: 1000), 
//po przesunięciu o 2 bity w prawo.
namespace Zadanie_8._01
{
    class Program
    {
        static int PrzesunWPrawoO2()
        {
            int tmp = 8;
            tmp >>= 2;
            return tmp;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(PrzesunWPrawoO2());
            Console.ReadKey();
        }
    }
}
