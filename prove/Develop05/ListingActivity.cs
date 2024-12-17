public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    // Constructor
    public ListingActivity(): base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0)
    {
        _count = 0; // Initialize the count to zero
        _prompts = new List<string>() 
        { 
            "Who are people you appreciate?", 
            "What are your personal strengths?", 
            "Who are people you have helped this week?", 
            "What are your favorite hobbies?" 
        };

    }

    // Run Method
    public void Run()
    {
        DisplayStartingMessage();

        // Get a random prompt
        string prompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");

        // Ask the user to list their responses
        List<string> userResponses = GetListFromUser();

        // Display the count of items listed
        _count = userResponses.Count;
        Console.WriteLine($"\nYou listed {_count} items!");

        DisplayEndingMessage();
    }

    // Method to Get a Random Prompt
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count); // Generate a random index
        return _prompts[index]; // Return the prompt at the random index
    }

    // Method to Get a List of Responses from the User
    public List<string> GetListFromUser()
    {
        List<string> userResponses = new List<string>();

        Console.WriteLine("Start listing items. Press Enter after each item. Type 'done' to finish:");

        string response;
        while (true)
        {
            response = Console.ReadLine();
            if (response.ToLower() == "done")
                break; // Stop if the user types "done"

            if (!string.IsNullOrWhiteSpace(response))
            {
                userResponses.Add(response); // Add the response to the list
            }
        }

        return userResponses;
    }

}