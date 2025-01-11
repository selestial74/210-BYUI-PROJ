using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        int number;

        // Collect numbers from the user
        Console.WriteLine("Let's gather some numbers! Type '0' when you're finished.");

        // Keep asking for numbers until the user enters 0
        do
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            // Only add the number if it's not zero
            if (number != 0)
            {
                numbers.Add(number);
            }

        } while (number != 0); // Stop when the user enters 0

        // If no numbers were entered, exit early
        if (numbers.Count == 0)
        {
            Console.WriteLine("You didn't enter any numbers. Exiting program.");
            return;
        }

        // Calculate the sum
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        // Calculate the average
        double average = sum / (double)numbers.Count;

        // Find the largest number
        int largest = numbers[0];
        foreach (int num in numbers)
        {
            if (num > largest)
            {
                largest = num;
            }
        }

        // Display results
        Console.WriteLine($"The sum of the numbers is: {sum}");
        Console.WriteLine($"The average of the numbers is: {average}");
        Console.WriteLine($"The largest number is: {largest}");

        // Stretch Challenge: Find the smallest positive number closest to zero
        int smallestPositive = int.MaxValue;
        foreach (int num in numbers)
        {
            if (num > 0 && num < smallestPositive)
            {
                smallestPositive = num;
            }
        }

        // Display the smallest positive number
        if (smallestPositive != int.MaxValue)
        {
            Console.WriteLine($"The smallest positive number closest to zero is: {smallestPositive}");
        }
        else
        {
            Console.WriteLine("There were no positive numbers entered.");
        }

        // Stretch Challenge: Sort and display the list
        numbers.Sort();
        Console.WriteLine("Here is your sorted list of numbers:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}
