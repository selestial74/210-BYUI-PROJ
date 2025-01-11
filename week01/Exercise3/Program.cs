using System;

class Program
{
    static void Main()
    {
        string playAgain;
        do
        {
            // Core Requirements
            int magicNumber;
            int userGuess;
            int guessCount = 0;

            // Step 1: Generate a random magic number
            Random randomGenerator = new Random();
            magicNumber = randomGenerator.Next(1, 101); // Random number between 1 and 100

            // Step 2: Loop until the user guesses the correct number
            do
            {
                // Ask for the guess
                Console.Write("Take a guess! What number do you think it is? ");
                userGuess = int.Parse(Console.ReadLine());
                guessCount++;

                // Step 3: Determine if the guess is too high, too low, or correct
                if (userGuess < magicNumber)
                {
                    Console.WriteLine("Hmm, try higher!");
                }
                else if (userGuess > magicNumber)
                {
                    Console.WriteLine("Too high, try lower.");
                }
                else
                {
                    Console.WriteLine($"Great job! You guessed it in {guessCount} tries.");
                }
            }
            while (userGuess != magicNumber); // Keep asking until the user guesses correctly

            // Step 4: Ask if they want to play again
            Console.Write("Want to play again? Type 'yes' to play, or anything else to quit: ");
            playAgain = Console.ReadLine().ToLower();
        }
        while (playAgain == "yes"); // Repeat if the user says 'yes'

        Console.WriteLine("Thanks for playing! Goodbye!");
    }
}
