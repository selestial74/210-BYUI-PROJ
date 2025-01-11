using System;

class Program
{
    static void Main()
    {
        // Asking the user for their first and last name
        string firstName = GetName("first");
        string lastName = GetName("last");

        // Display the formatted name
        DisplayFormattedName(firstName, lastName);
    }

    // Function to prompt the user for a name (first or last)
    static string GetName(string type)
    {
        Console.Write($"What is your {type} name? ");
        return Console.ReadLine();
    }

    // Function to display the formatted name
    static void DisplayFormattedName(string firstName, string lastName)
    {
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}
