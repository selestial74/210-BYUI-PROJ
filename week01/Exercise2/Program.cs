using System;

class Program
{
    static void Main()
    {
        // Program that ask the user for their grade percentage
        Console.Write("Enter your grade percentage: ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        // Variable to store the letter grade
        string letterGrade = "";

        // Determine the letter grade
        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        // Print the letter grade
        Console.WriteLine($"Your letter grade is: {letterGrade}");

        // Check if the user passed or failed
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course!");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass the course. Better luck next time!");
        }
    }
}
