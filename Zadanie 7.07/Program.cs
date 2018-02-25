using System;
//Stwórz funkcję bool CzyJest2(char x, char y, string napis) , która zwraca true, jeśli 
//w napisie napis można wskazać dokładnie dwie sekwencje takich trzech znaków, że pierwszy 
//ma wartość parametru x (przesłanego jako argument), drugi znak jest dowolny, a trzeci 
//znak ma wartość parametru y. W przeciwnym wypadku funkcja zwraca false.
namespace Zadanie_7._07
{
    class Program
    {
        static bool CzyJest2(char x, char y, string napis)
        {
            int licznik = 0;
            for (int i = 0; i < napis.Length - 2; i++)
            {
                if (napis[i] == x && napis[i + 2] == y)
                {
                    licznik++;
                }
            }
            if (licznik == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CzyJest2('a', 'z', "aazabz"));
            Console.ReadKey();
        }
    }
}
