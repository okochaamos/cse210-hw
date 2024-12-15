using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Amos Okocha", "Programming with Classes");

        string summary = assignment1.GetSummary();
        Console.WriteLine(summary);

        
        // Create a MathAssignment object
        MathAssignment mathAssignment = new MathAssignment("Chimaobi Okoro", "Fractions", "7.3", "8-19");

        // Display the summary
        Console.WriteLine(mathAssignment.GetSummary());

        // Display the homework list
        Console.WriteLine(mathAssignment.GetHomeworkList());
        
        WritingAssignment writingAssignment = new WritingAssignment("Mary Jane", "European History", "The Fall of Rome");

        // Display the writing information
        Console.WriteLine(writingAssignment.GetWritingInformation());
        
        

    }
}