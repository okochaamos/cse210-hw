using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your percentage score?");

        string myScore = Console.ReadLine();
        int percentageScore = int.Parse(myScore);

        if (percentageScore >= 90)
        {
            Console.WriteLine("You made an A");
        }

        
        else if (percentageScore >= 80)
        {
            Console.WriteLine("You made a B");

        }
        else if (percentageScore >= 70)
        {
            Console.WriteLine("You made a C");

        }
        else
        {
            Console.WriteLine("You made a F");
        }

        if (percentageScore >= 70)
        {
            Console.WriteLine("Congratulations you made it.");
        }
        else 
        {
            Console.WriteLine("Put more efforts next time.");
        }
    }
}