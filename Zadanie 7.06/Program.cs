using System;
//Stwórz funkcję bool CzyJest1(char x, char y, string napis) , która zwraca true, 
//jeśli w napisie napis można wskazać dokładnie dwie sekwencje znaków x i y takich,
//że znak x (przesłany jako argument) poprzedza bezpośrednio znak y 
//(przesłany jako argument). W przeciwnym wypadku funkcja zwraca false.
namespace Zadanie_7._06
{
    class Program
    {
        static bool CzyJest1(char x, char y, string napis)
        {
            int licznik = 0;
            for (int i = 0; i < napis.Length - 1; i++)
            {
                if (napis[i] == x && napis[i + 1] == y)
                {
                    licznik += 1;
                }
            }
            if (licznik == 2)
                return true;
            return false;
        }
        static void Main(string[] args)
        {

            Console.WriteLine(CzyJest1('a', 'b', "abbab"));
            Console.ReadKey();
        }
    }
}
