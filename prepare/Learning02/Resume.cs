public class Resume
{
    public string _personName;

    // List to hold the job history
    public List<Job> _jobs = new List<Job>();

    // Method to display the resume details, including all job details
    public void Display()
    {
        Console.WriteLine($"Name: {_personName}");
        Console.WriteLine("Jobs");
        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }
}
