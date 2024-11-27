
// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Testing the default constructor (1/1)
//         Fraction fraction1 = new Fraction();
//         Console.WriteLine($"Fraction 1: {fraction1.GetFractionString()} = {fraction1.GetDecimalValue()}");

//         // Testing the constructor with one parameter (e.g., 5/1)
//         Fraction fraction2 = new Fraction(5);
//         Console.WriteLine($"Fraction 2: {fraction2.GetFractionString()} = {fraction2.GetDecimalValue()}");

//         // Testing the constructor with two parameters (e.g., 3/4)
//         Fraction fraction3 = new Fraction(3, 4);
//         Console.WriteLine($"Fraction 3: {fraction3.GetFractionString()} = {fraction3.GetDecimalValue()}");

//         // Testing getters and setters
//         fraction3.SetNumerator(1);
//         fraction3.SetDenominator(3);
//         Console.WriteLine($"Updated Fraction 3: {fraction3.GetFractionString()} = {fraction3.GetDecimalValue()}");

        
//     }
// }

using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        // Exceeding requirements: Library of scriptures
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John", 3 , 16), "For God so loved the world that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            new Scripture(new Reference("Proverbs", 3 , 5 , 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
            new Scripture(new Reference("Psalm", 23, 1 , 2), "The Lord is my shepherd; I shall not want. He maketh me to lie down in green pastures."),
            new Scripture(new Reference("Joshua", 1 , 8), "This book of the law shall not depart out of thy mouth; but thou shalt meditate therein day and night, that thou mayest observe to do according to all that is written therein: for then thou shalt make thy way prosperous, and then thou shalt have good success"),
            new Scripture(new Reference("John", 14, 6), "Jesus saith unto him, I am the way, the truth, and the life: no man cometh unto the Father, but by me")
        };

        // Select a random scripture
        Random random = new Random();
        Scripture selectedScripture = scriptures[random.Next(scriptures.Count)];

        Console.Clear();
        Console.WriteLine("Welcome to the Scripture Memorization Tool!");
        Console.WriteLine("Press Enter to begin or type 'quit' at any time to exit.\n");

        while (!selectedScripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText());
            Console.Write("\nPress Enter to hide words or type 'quit' to exit: ");
            string userInput = Console.ReadLine();

            if (userInput?.ToLower() == "quit")
            {
                Console.WriteLine("Thank you for using the Scripture Memorization Tool!");
                break;
            }

            selectedScripture.HideRandomWords(3); // Hide 3 random words
        }

        if (selectedScripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText());
            Console.WriteLine("\nCongratulations! You have successfully memorized the scripture!");
        }
    }
}
