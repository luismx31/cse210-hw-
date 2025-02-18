using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a base "Assignment" object
        Assignment a1 = new Assignment("Luis Moreno", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        // Now create the derived class assignments
        MathAss a2 = new MathAss("Juan Fernandez", "History", "7.0", "2-5");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworklist());

        WritingAss a3 = new WritingAss("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}