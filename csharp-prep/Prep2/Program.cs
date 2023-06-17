using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int gradePerc = int.Parse(userInput);
        string letter;
        string message;

        if (gradePerc >= 90)
        {
            letter = "A";
        }
        else if (gradePerc >= 80)
        {
            letter = "B";
        }
        else if (gradePerc >= 70)
        {
            letter = "C";
        }
        else if (gradePerc >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (gradePerc > 69)
        {
            message = "Congratulations! You have passed the class";
        }
        else
        {
            message = "Keep working on it!";
        }

        Console.WriteLine($"Your letter grade is: {letter}");
        Console.WriteLine(message);
    }
}