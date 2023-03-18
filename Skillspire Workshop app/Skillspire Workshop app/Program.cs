using System;

namespace Skillspire_Workshop_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome to Skilspire Dice Game!");

            //Variables
            int player_dice1;
            int player_dice2;
            int player_total;

            int opponent_dice1;
            int opponent_dice2;
            int opponent_total;

            (int, int) score = (0, 0);

            //Intializing Randomizer Instance
            var rand = new Random();

            bool play = true;
            bool running = true;
            string userInput;

            int times_played = 0;

            while (running)
            {
                //If play is true, the game will start
                if (play)
                {
                    //Player Dice Roll
                    player_dice1 = rand.Next(0, 7);
                    player_dice2 = rand.Next(0, 7);
                    Console.WriteLine("Dice 1 = " + player_dice1);
                    Console.WriteLine("Dice 2 = " + player_dice2);

                    //Calculating player Total
                    player_total = player_dice1 + player_dice2;
                    Console.WriteLine($"Total:  + {player_total}");

                    //Opponent Dice Roll
                    opponent_dice1 = rand.Next(0, 7);
                    opponent_dice2 = rand.Next(0, 7);
                    Console.WriteLine("Dice 1 = " + opponent_dice1);
                    Console.WriteLine("Dice 2 = " + opponent_dice2);

                    //Calculating Opponent Total
                    opponent_total = opponent_dice1 + opponent_dice2;
                    Console.WriteLine($"Total:  + {opponent_total}");

                    //Comparing Totals
                    if (player_total > opponent_total)
                    {
                        score.Item1 += 1;
                        Console.WriteLine("Nice you've won");
                        
                    }else if (player_total < opponent_total)
                    {
                        score.Item2 += 1;
                        Console.WriteLine("You Lose.  Better try next time.");
                    }else if (player_total == opponent_total)
                    {
                        Console.WriteLine("A Tie.  Wow!  What are the odds.");
                    }

                    //Keeping score of player and opponent wins
                    Console.WriteLine($"The score is You - {score.Item1} : Computer - {score.Item2}");

                    //At the end of rolling dice game will pause
                    play = false;
                    times_played += 1;
                }

                //After dice roll, game will ask if you want to play again.
                Console.WriteLine("Would you like to play again?");
                Console.WriteLine("(y/n)");

                userInput = Console.ReadLine();

                //User will input either "y" for yes or "n" for no

                if (userInput == "y")
                {
                    play = true;
                }
                else if (userInput == "n")
                {
                    play = false;
                    running = false;
                    Console.WriteLine("GoodBye and Thank you for playing");

                    //Printing total dice rolls
                    Console.WriteLine("You have completed a total of " + times_played + " dice rolls.");
                }

                
                            

            }

            
        }
    }
}
