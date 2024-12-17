public class BreathingActivity : Activity
{
    // Constructor: Passes values to the base class
    public BreathingActivity() : base("Breathing", "This activity will help you relax by breathing slowly. Clear your mind and focus on your breathing.", 0)
    {
    }

    // Run Method: Execute the Breathing Activity
    public void Run()
    {
        // Display starting message
        DisplayStartingMessage();

        // Loop for the duration of the activity
        for (int i = 0; i < _duration / 10; i++) // Assuming each cycle takes 10 seconds
        {
            Console.WriteLine("\nBreathe in...");
            ShowCountDown(5); // Breathe in for 5 seconds

            Console.WriteLine("Now breathe out...");
            ShowCountDown(5); // Breathe out for 5 seconds
        }

        // Display ending message
        DisplayEndingMessage();
    }
}
