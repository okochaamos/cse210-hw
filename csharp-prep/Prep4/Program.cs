using System;

using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Type in the numbers of your choice");
        string response;
        int myNumbers = -1;


        

        Console.WriteLine(numbers);

        while (myNumbers != 0)
        {
            Console.WriteLine("Type in the numbers of your choice");

            // Read input and attempt to parse it
            response = Console.ReadLine();
            

            if (!int.TryParse(response, out myNumbers))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue; 
            }

            if (myNumbers != 0)
            {
                numbers.Add(myNumbers);
            }
        
        
        }
        Console.WriteLine("Numbers entered: " + string.Join(", ", numbers));

            

        if (numbers.Count > 0)
        {
            int sum = numbers.Sum();
            double average = numbers.Average();
            int max = numbers.Max();

            Console.WriteLine("The sum of the numbers is: " + sum);
            Console.WriteLine("The average of the numbers is: " + average);
            Console.WriteLine("The largest number is: " + max);
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }

    }
}
