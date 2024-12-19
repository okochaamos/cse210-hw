class Program
{
    static GoalManager goalManager = new GoalManager();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("==== My Goal Tracker ====");
            Console.WriteLine("1. Create a New Goal");
            Console.WriteLine("2. View Goals");
            Console.WriteLine("3. Record an Event");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    goalManager.ListGoals();
                    WaitForKeyPress();
                    break;
                case "3":
                    RecordEvent();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Press Enter to try again.");
                    WaitForKeyPress();
                    break;
            }
        }
    }

    static void CreateGoal()
    {
        Console.Clear();
        Console.WriteLine("Select Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Checklist Goal");
        Console.WriteLine("3. Eternal Goal");
        Console.Write("Choose an option: ");
        string choice = Console.ReadLine();

        Console.Write("Enter Goal Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Goal Description: ");
        string description = Console.ReadLine();

        Console.Write("Enter Points for Completing the Goal: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                goalManager.AddGoal(new SimpleGoal(name, description, points));
                break;
            case "2":
                Console.Write("Enter Target Number of Completions: ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("Enter Bonus Points for Completing All: ");
                int bonus = int.Parse(Console.ReadLine());

                goalManager.AddGoal(new ChecklistGoal(name, description, points, target, bonus));
                break;
            case "3":
                goalManager.AddGoal(new EternalGoal(name, description, points));
                break;
            default:
                Console.WriteLine("Invalid choice. Press Enter to go back.");
                WaitForKeyPress();
                break;
        }
    }

    static void RecordEvent()
    {
        Console.Clear();
        goalManager.ListGoals();
        Console.WriteLine("Select a Goal to Record an Event:");
        Console.Write("Enter Goal Number: ");
        int goalNumber = int.Parse(Console.ReadLine()) - 1;

        goalManager.RecordEvent(goalNumber);
        WaitForKeyPress();
    }

    static void WaitForKeyPress()
    {
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }
}