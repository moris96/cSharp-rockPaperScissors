using System;

namespace rockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int playerScore = 0;
            int pcScore = 0;

            Console.WriteLine("Rock Paper Scissors in C#!");

            while(playerScore != 3 && pcScore != 3)
            {
                Console.WriteLine("Player score: " + playerScore + ". PC score: " + pcScore);
                Console.WriteLine("Please enter 'r' for rock, 'p' for paper, 's' for scissors");
                string playerChoice = Console.ReadLine();

                int pcChoice = random.Next(0, 3);

                if(pcChoice == 0)
                {
                    Console.WriteLine("PC chooses rock");

                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("It's a tie!");
                            break;
                        case "p":
                            Console.WriteLine("You win!");
                            playerScore++;
                            break;
                        case "s":
                            Console.WriteLine("You lose!");
                            pcScore++;
                            break;
                    }
                }
                else if(pcChoice == 1) 
                {
                    Console.WriteLine("PC chooses paper");

                    switch(playerChoice)
                    {
                        case "r":
                            Console.WriteLine("You lose!");
                            pcScore++;
                            break;
                        case "p":
                            Console.WriteLine("It's a tie!");
                            break;
                        case "s":
                            Console.WriteLine("You win!");
                            playerScore++;
                            break;
                    }
                }
                else if(pcChoice == 2)
                {
                    Console.WriteLine("PC chooses scissors");

                    switch(playerChoice)
                    {
                        case "r":
                            Console.WriteLine("You win!");
                            playerScore++;
                            break;
                        case "p":
                            Console.WriteLine("You lose!");
                            pcScore++;
                            break;
                        case "s":
                            Console.WriteLine("It's a tie!");
                            break;
                    }
                }
            }

            if(playerScore == 3)
            {
                Console.WriteLine("You're the champion!");
            }
            else
            {
                Console.WriteLine("You lose!");
            }
        }
    }
}