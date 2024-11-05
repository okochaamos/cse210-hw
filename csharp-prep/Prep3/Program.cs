using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("What is the secret number?");
        int secretNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("What is your guess?");

        int myGuess = int.Parse(Console.ReadLine());

    

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