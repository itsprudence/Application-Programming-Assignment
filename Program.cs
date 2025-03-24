// See https://aka.ms/new-console-template for more information


using System;

class LuckyNumberGame
{
    static void Main()
    {
        Console.WriteLine("Enter the number of rounds you wish to play: ");
        int rounds = int.Parse(Console.ReadLine());

        while(int.TryParse(Console.ReadLine(), out rounds)|| rounds == 0){
            Console.Write("Invalid input. Please enter a non-zero number.");
        }


        int score = 0;

        Random random = new Random(); // Random number generator

        for (int i = 0; i < rounds; i++)
        {
            Console.WriteLine($"Round {i + 1}: Enter your lucky number: ");
            int luckyNumber = int.Parse(Console.ReadLine());

            
            int secretNumber = random.Next(1, 101); // Random number between 1 and 100

            Console.WriteLine($"Secret number is: {secretNumber}");

            if (luckyNumber == secretNumber)
            {
                Console.WriteLine("Draw");
                score++;
            }
            else if (luckyNumber % 2 == 0 && secretNumber % 2 == 0)
            {
                Console.WriteLine("Win");
                score += 3;
            }
            else
            {
                Console.WriteLine("Loss");
                score -= 3;
            }

            Console.WriteLine($"Current score: {score}");
        }

        if (score > 0)
        {
            Console.WriteLine("Congratulations! You have won!");
        }
        else if (score == 0)
        {
            Console.WriteLine("It's a draw!");
        }
        else
        {
            Console.WriteLine("You lost. Better luck next time!");
        }
    }
}


