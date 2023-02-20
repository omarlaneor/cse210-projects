
using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("\nSamuel Bennett", "Multiplication\n");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment("\nRoberto Rodriguez", "Fractions", "7.3", "8-19\n");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}