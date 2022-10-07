using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem a számot: ");
            int bekertSzam = Convert.ToInt32(Console.ReadLine());
            string kettesRendszer = "";
            int index = 0;
            while (bekertSzam > 0)
            {
                kettesRendszer = Convert.ToString(bekertSzam % 2) + kettesRendszer;
                bekertSzam /= 2;
                index++;
            }
            Console.WriteLine(kettesRendszer);
        }

    }
    }
