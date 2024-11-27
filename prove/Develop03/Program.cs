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
