using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("K�rem a sz�veget: ");
            string vizsgalandoSzo = Console.ReadLine();
            bool vizsgalat = true;

            for (int i = 0; i < vizsgalandoSzo.Length/2; i++)
            {
                if (vizsgalandoSzo[i] != vizsgalandoSzo[vizsgalandoSzo.Length-i-1])
                {
                    vizsgalat = false;
                }
            }

            if (vizsgalat)
            {
                Console.WriteLine("J�");
            }

            else
            {
                Console.WriteLine("Nem j�");
            }
        }
    }
}