public class ReflectingActivity : Activity
{
    private List<string> _prompts;   // List of reflection prompts
    private List<string> _questions; // List of questions about the prompts

    // Constructor
    public ReflectingActivity() : base("Reflecting", "This activity will help you reflect on times when you showed strength and resilience.", 0)
    {
        _prompts = new List<string>() 
        { 
            "Think of a time when you stood up for someone.",
            "Think of a time when you overcame a challenge.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something really difficult."
        };

        _questions = new List<string>() 
        { 
            "Why was this experience meaningful to you?",
            "How did you feel afterward?",
            "What did you learn about yourself?",
            "How can you apply this experience in the future?"
        };
    }

    // Run Method
    public void Run()
    {
        DisplayStartingMessage();

        string prompt = GetRandomPrompt();
        Console.WriteLine($"\nReflect on the following prompt:\n--- {prompt} ---\n");

        DisplayPrompt();
        DisplayQuestions();

        DisplayEndingMessage();
    }

    // Get a Random Prompt
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    // Get a Random Question
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    // Display the Prompt
    public void DisplayPrompt()
    {
        Console.WriteLine("\nThink deeply about the prompt...");
        ShowSpinner(5); // Simulates a short pause to allow thinking
    }

    // Display Questions About the Prompt
    public void DisplayQuestions()
    {
        Console.WriteLine("\nNow, consider the following questions. Press Enter to continue to the next question.\n");

        foreach (var question in _questions)
        {
            Console.WriteLine($"- {question}");
            ShowSpinner(3); // Pauses briefly for the user to reflect
            Console.WriteLine();
        }
    }
}