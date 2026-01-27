using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Logan Davis", "Algebra");
        Console.WriteLine(assignment1.GetSummary());
        
        MathAssignment assignment2 = new MathAssignment("Jeremy Fraiser", "Fractions", "4.2", "3-14");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment("Richard Smith", "American Government", "What is Lobbying?");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}