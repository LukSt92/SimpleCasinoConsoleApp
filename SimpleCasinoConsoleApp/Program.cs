using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCasinoConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Guy player = new Guy() { Cash = 100, Name = "The player" };
            Random random = new Random();
            double odds = 0.75;

            Console.WriteLine("Welcome to the casino. the odds are " + odds);

            while (player.Cash > 0)
            {
                player.WriteMyInfo();
                Console.Write("how much do you want to bet: ");
                string howMuch = Console.ReadLine();
                if (int.TryParse(howMuch, out int amount))
                {
                    int pot = player.GiveCash(amount);
                    if (random.NextDouble() > odds)
                    {
                        pot *= 2;
                        player.ReceiveCash(pot);
                        Console.WriteLine("You win " + pot);
                    }
                    else
                    {
                        Console.WriteLine("Bad luck, you lose.");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }

            }
            Console.WriteLine("The house always wins.");
        }
    }
}
