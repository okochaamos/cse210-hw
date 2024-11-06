using System;

class Program
{
    static void Main(string[] args)
    {
        
        Random randomGenerator = new Random();
        int secretNumber = randomGenerator.Next(1, 100);

        Console.WriteLine($"My secret number is: {secretNumber}"); 
        int myGuess = -1;
        string response;

        while (myGuess != secretNumber)
        {
            Console.WriteLine("What is your guess?");

            // Read input and attempt to parse it
            response = Console.ReadLine();

            if (!int.TryParse(response, out myGuess))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue; // Skip the rest of the loop and ask for input again
            }

            if (myGuess == secretNumber)
            {
                Console.WriteLine("Congratulations, you guessed it!");
            }
            else if (myGuess > secretNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }
        }

    }

}