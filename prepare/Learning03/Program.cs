using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a fraction using the default constructor (1/1)
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetFractionString()); // Output: 1/1
        Console.WriteLine(fraction1.GetDecimalValue());   // Output: 1

        // Create a fraction using the constructor with a whole number (5/1)
        Fraction fraction2 = new Fraction(5);
        Console.WriteLine(fraction2.GetFractionString()); // Output: 5/1
        Console.WriteLine(fraction2.GetDecimalValue());   // Output: 5

        // Create a fraction using the constructor with a numerator and denominator (3/4)
        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine(fraction3.GetFractionString()); // Output: 3/4
        Console.WriteLine(fraction3.GetDecimalValue());   // Output: 0.75

        // Create a fraction using the constructor with a numerator and denominator (1/3)
        Fraction fraction4 = new Fraction(1, 3);
        Console.WriteLine(fraction4.GetFractionString()); // Output: 1/3
        Console.WriteLine(fraction4.GetDecimalValue());   // Output: 0.3333333333333333
    }
}