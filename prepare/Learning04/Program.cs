using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        MathAssignment b2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(b2.GetSummary());
        Console.WriteLine(b2.GetHomeworkList());

        WritingAssignment c3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(c3.GetSummary());
        Console.WriteLine(c3.GetWritingInformation());
    }
}