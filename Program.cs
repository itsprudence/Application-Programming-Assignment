using System;

class LuckyNumberGame
{
    static void Main()
    {
        int rounds;
        int secretNumber = 5; 
        int totalScore = 0;

        Console.WriteLine("Welcome to the Lucky Number Game!");

        while (true)
        {
            Console.Write("Enter the number of rounds you wish to play (must be at least 1): ");
            if (int.TryParse(Console.ReadLine(), out rounds) && rounds > 0)
            {
                break;
            }
            Console.WriteLine("Invalid input! Please enter a positive number.");
        }

        for (int i = 1; i <= rounds; i++)
        {
            int luckyNumber;

            while (true)
            {
                Console.Write($"Enter your lucky number for round {i}: ");
                if (int.TryParse(Console.ReadLine(), out luckyNumber))
                {
                    break;
                }
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }

            int remainder = luckyNumber % secretNumber;

            if (remainder == 0)
            {
                Console.WriteLine("It's a draw! Score +1");
                totalScore += 1;
            }
            else if (remainder % 2 == 0)
            {
                Console.WriteLine("You win this round! Score +3");
                totalScore += 3;
            }
            else
            {
                Console.WriteLine("You lose this round! Score -3");
                totalScore -= 3;
            }
        }

        Console.WriteLine("\nGame Over! Your final score is: " + totalScore);

        if (totalScore > 0)
        {
            Console.WriteLine("Congratulations! You won the game.");
        }
        else
        {
            Console.WriteLine("Better luck next time! You lost the game.");
        }
    }
}
