using System;

namespace Labb4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");

            Random random = new Random();
            int num = random.Next(1, 21);

            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Gissa ett nummer mellan 1 och 20: ");
                int gis = Convert.ToInt32(Console.ReadLine());

                if (CheckGuess(gis, num))
                {
                    Console.WriteLine("Wohoo! Du gjorde det!");
                    return;
                }

                if (gis < num)
                {
                    Console.WriteLine("Tyvärr du gissade för lågt!");
                }
                else
                {
                    Console.WriteLine("Tyvärr du gissade för högt!");
                }
            }

            Console.WriteLine("Tyvärr du lyckades inte gissa talet på fem försök!");
        }

        static bool CheckGuess(int gis, int num)
        {
            return gis == num;
        }
    }
}