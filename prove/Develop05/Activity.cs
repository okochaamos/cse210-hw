public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity!");
        Console.WriteLine(_description);
        Console.WriteLine("How long (in seconds) would you like to do this activity?");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready to begin...\n");
        ShowSpinner(5); // Pause briefly
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done! You have completed the activity.");
        ShowSpinner(5); // Pause briefly
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}... ");
            System.Threading.Thread.Sleep(3000); // Pause for 1 second
        }
        Console.WriteLine();
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("|");
            System.Threading.Thread.Sleep(500);
            Console.Write("\b/"); 
            System.Threading.Thread.Sleep(500);
            Console.Write("\b-"); 
            System.Threading.Thread.Sleep(500);
            Console.Write("\b\\");
            System.Threading.Thread.Sleep(500);
            Console.Write("\b");
        }
    }
}
