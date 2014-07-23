using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number between 1 and 100.");
            const int MAX_CHANCES = 10;

            int randomNumber = new Random().Next(1, 101); // moved from inside the loop

            int chance = 1;
            do
            {
                //int randomNumber = new Random().Next(1, 101);

                Console.WriteLine("Chance {0} of {1}...", chance, MAX_CHANCES);
                int guess = int.Parse(Console.ReadLine());

                if (guess < randomNumber)
                {
                    Console.WriteLine("That's too low.");
                }
                else if (guess > randomNumber)
                {
                    Console.WriteLine("That's too high.");
                }
                else
                {
                    Console.WriteLine("You got it!");
                    break; // added to exit the loop
                }

                //chance++;
            } while (chance++ < MAX_CHANCES); // Move increment to occur after evaluation

            Console.WriteLine("Game over.");
        }
    }
}
