using System;

namespace Lab4._1_Dice_Rolling
{
    class Program
    {
        static int RandNum(int input)
        {
            Random rand = new Random();

            int randomNum = rand.Next(1, input + 1);

            return randomNum;

        }

        static int Rolled(int randomNum)
        {
            int roll = RandNum(randomNum);

            return roll;
        }


        static void Main(string[] args)
        {
            bool keepRolling = true;
            int sum = 0;



            Console.WriteLine("Welcome to the Grand Circus Casino!");
            Console.WriteLine();

            while (keepRolling)
            {
                Console.Write("How many sides should each die have?");

                int input = int.Parse(Console.ReadLine());


                if (input == 6)
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

                    Console.Write("Roll again? (y/n):");
                    string rollAgain = Console.ReadLine().ToUpper();
                    if (rollAgain == "N")
                    {
                        Console.WriteLine("Thanks for playing. Press any key to exit...");
                        keepRolling = false;
                        Console.ReadLine();
                    }
                    else if (rollAgain != "Y")
                    {
                        Console.WriteLine("That is not a valid input. Rolling again.");
                    }
                }
                else
                {
                    int rollOne = Rolled(input);
                    int rollTwo = Rolled(input);

                    sum = rollOne + rollTwo;

                    Console.WriteLine($"You rolled a {rollOne} and a {rollTwo} ({sum} total)");
                    Console.Write("Roll again? (y/n):");
                    string rollAgain = Console.ReadLine().ToUpper();
                    if (rollAgain == "N")
                    {
                        Console.WriteLine("Thanks for playing. Press any key to exit...");
                        keepRolling = false;
                        Console.ReadLine();
                    }
                    else if (rollAgain != "Y")
                    {
                        Console.WriteLine("That is not a valid input. Rolling again.");
                    }
                }


            }


        }
    }
}
