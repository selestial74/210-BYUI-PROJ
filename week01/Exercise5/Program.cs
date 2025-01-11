using System;

class Program
{
    // Function to display a welcoming message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program! We’re excited to have you here.");
    }

    // Function to prompt for the user's name and return it
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    // Function to prompt for the user's favorite number and return it
    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int number;
        // Keep asking for input until a valid number is entered
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.Write("Oops! That’s not a valid number. Please enter a valid favorite number: ");
        }
        return number;
    }

    // Function to calculate and return the square of the number
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Function to display the result in a friendly format
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your favorite number is {squaredNumber}. Isn’t that amazing?");
    }

    // Main function to orchestrate the program
    static void Main(string[] args)
    {
        DisplayWelcome();  // Greet the user

        // Get user's name and favorite number
        string name = PromptUserName();
        int favoriteNumber = PromptUserNumber();

        // Square the user's favorite number
        int squaredNumber = SquareNumber(favoriteNumber);

        // Display the result in a fun and engaging way
        DisplayResult(name, squaredNumber);
    }
}
