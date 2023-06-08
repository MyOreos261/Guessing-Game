using System;

class Program
{
    static void Main(string[] args)
    {
        int targetNumber = new Random().Next(1, 101); // Generate a random number between 1 and 100
        int guess = 0;
        int attempts = 0;

        Console.WriteLine("Welcome to the Guessing Game!");
        Console.WriteLine("Try to guess the target number between 1 and 100.");
        Console.WriteLine("You have 10 attempts. Good luck!\n");

        while (guess != targetNumber && attempts < 10)
        {
            Console.Write("Enter your guess: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out guess))
            {
                attempts++;

                if (guess < targetNumber)
                {
                    Console.WriteLine("Higher! Attempts remaining: " + (10 - attempts));
                }
                else if (guess > targetNumber)
                {
                    Console.WriteLine("Lower! Attempts remaining: " + (10 - attempts));
                }
                else
                {
                    Console.WriteLine("Congratulations! You guessed the correct number: " + targetNumber);
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }
        }

        if (guess != targetNumber)
        {
            Console.WriteLine("Game over! You did not guess the correct number. The target number was: " + targetNumber);
        }

        Console.ReadLine();
    }
}
