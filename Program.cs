using System;

namespace Lab4._1_Dice_Rolling
{
    class Program
    {
        static int RandNum(int input)  // Method to generate a random number based out the amount of sides the user wants.
        {
            Random rand = new Random();

            int randomNum = rand.Next(1, input + 1);

            return randomNum;

        }

        static int Rolled(int randomNum)
        {
            int roll = RandNum(randomNum);

            return roll;
        }  // Method is not really needed for code to run. Could have changed some variable names in the DiceRoller Method instead of including this
                                             // but I wanted the practice creating a methof that takes an input and returns a var.
        static void DiceRoller(int input) //Method that outputs the dice rolled, their sum, and any specail combinations from what is rolled.
        {
            int sum = 0;
            if (input == 6) // Adds special Dice Combinations if a 6 sided die is used.
            {
                int rollOne = Rolled(input);
                int rollTwo = Rolled(input);

                sum = rollOne + rollTwo;

                Console.WriteLine($"You rolled a {rollOne} and a {rollTwo} ({sum} total)");
                if (rollOne == 1 && rollTwo == 1)
                {
                    Console.WriteLine("Snake Eyes!");
                }
                else if ((rollOne == 1 && rollTwo == 2) || (rollOne == 2 && rollTwo == 1))
                {
                    Console.WriteLine("Ace Deuce!");
                }
                else if (rollOne == 6 && rollTwo == 6)
                {
                    Console.WriteLine("Box Cars!");
                }

                if (sum == 7 || sum == 11)
                {
                    Console.WriteLine("Win!");
                }
                else if (sum == 2 || sum == 3 || sum == 12)
                {
                    Console.WriteLine("Craps!");
                }

            }
            else
            {
                int rollOne = Rolled(input);
                int rollTwo = Rolled(input);

                sum = rollOne + rollTwo;

                Console.WriteLine($"You rolled a {rollOne} and a {rollTwo} ({sum} total)");
                
            }

        } //Dice Roller Method That displays Dice output to Console
  


        static void Main(string[] args)
        {
            bool keepRolling = true;

            Console.WriteLine("Welcome to the Grand Circus Casino!");
            Console.WriteLine();
            
            while (keepRolling)
            {
                Console.Write("How many sides should each die have?");

                try // Try Catch Block to make sure a 'number' is used. Will make the user inut another number if one is not used.

                {
                    int input = int.Parse(Console.ReadLine());
                    DiceRoller(input); //takes input from user, and puts it through the DiceRoller Method

                    Console.Write("Roll again? (y/n):"); // Checks for Valid input to keep rolling.
                    string rollAgain = Console.ReadLine().ToUpper();
                    if (rollAgain == "N")
                    {
                        Console.WriteLine("Thanks for playing. Press Enter key to exit...");
                        keepRolling = false;
                        Console.ReadLine();
                    }
                    else if (rollAgain != "Y")
                    {
                        Console.WriteLine("That is not a valid input. Rolling again.");
                    }

                }
                catch // end of catch block to make sure the user only uses a number.
                {
                    Console.WriteLine("That is not a valid input. Numbers only.");
                    continue;
                }

            }

        }
    }
}
