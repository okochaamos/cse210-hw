
public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public void DisplayJobDetails()
    {
        Console.WriteLine($"Job Title : {_jobTitle} ({_company}) {_startYear} - {_endYear}");
    }
}
