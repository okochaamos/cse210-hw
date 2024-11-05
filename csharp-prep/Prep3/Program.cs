using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("What is the secret number?");
        int secretNumber = int.Parse(Console.ReadLine());

        int myGuess = -1; // Initialize myGuess to a value that won't match secretNumber initially

        while (myGuess != secretNumber)
        {
            Console.WriteLine("What is your guess?");
            myGuess = int.Parse(Console.ReadLine());

            if (myGuess == secretNumber)
            {
                Console.WriteLine("Congratulations, you guessed it!");
            }
            else if (myGuess > secretNumber)
            {
                Console.WriteLine("Try guessing lower.");
            }
            else
            {
                Console.WriteLine("Try guessing higher.");
            }
        }
        
    }

}