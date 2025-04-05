using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment Ass = new Assignment("Samuel Bennet", "Multiplication");
        Console.WriteLine(Ass.GetSummary());
        Console.WriteLine();

        MathAssignment Math = new MathAssignment("Roberto Rodriguez","Fractions","7.3","8-19");
        Console.WriteLine(Math.GetSummary());
        Console.WriteLine(Math.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment writing = new WritingAssignment("Mary Water","European History", "The Causes of World War II");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}