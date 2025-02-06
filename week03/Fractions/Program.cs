using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating fractions with different constructors
        Fraction fraction1 = new Fraction();
        DisplayFractionInfo(fraction1);

        Fraction fraction2 = new Fraction(5);
        DisplayFractionInfo(fraction2);

        Fraction fraction3 = new Fraction(3, 4);
        DisplayFractionInfo(fraction3);

        Fraction fraction4 = new Fraction(1, 3);
        DisplayFractionInfo(fraction4);

        // Modifying a fraction using setters
        Fraction fraction5 = new Fraction(2, 5);
        Console.WriteLine("Original fraction:");
        DisplayFractionInfo(fraction5);
        
        // Updating the fraction values
        fraction5.SetNumerator(7);
        fraction5.SetDenominator(8);
        Console.WriteLine("Updated fraction:");
        DisplayFractionInfo(fraction5);
    }

    // Helper method to display fraction details
    static void DisplayFractionInfo(Fraction fraction)
    {
        Console.WriteLine($"Fraction: {fraction.GetFractionString()}");
        Console.WriteLine($"Decimal value: {fraction.GetDecimalValue()}\n");
    }
}
