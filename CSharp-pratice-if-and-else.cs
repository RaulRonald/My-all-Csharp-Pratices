using static System.Random;
using static System.Console;
using static System.Math;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            //initiate the random values of my sum and save the result

            Random dice = new Random();

            int roll1 = dice.Next(1, 7);
            int roll2 = dice.Next(1, 7);
            int roll3 = dice.Next(1, 7);

            int total = roll1 + roll2 + roll3;

            //printing

            Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

            //if the value is higher than fifteen i win.

            if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
            {
                Console.WriteLine("You rolled doubles! +2 bonus to total!");
                total += 2;
            }
            if ((roll1 == roll2) && (roll2 == roll3))
            {
                Console.WriteLine("You rolled triples! +6 bonus to total!");
                total += 6;
            }

            if (total >= 15)
            {
                Console.WriteLine("You win!");
            }
            else if (total < 15)
            {
                Console.WriteLine("Sorry, you lose.");
            }
        }
    }
}