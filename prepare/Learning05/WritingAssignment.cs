public class WritingAssignment : Assignment
{
    // Private field for the title
    private string _title;

    // Constructor initializing base and new attributes
    public WritingAssignment(string studentName, string topic, string title) 
        : base(studentName, topic)
    {
        _title = title;
    }

    // Method to get writing information
    public string GetWritingInformation()
    {
        // Using the GetStudentName() method because _studentName is private in the base class
        string studentName = GetStudentName();

        return $"{_title} by {studentName}";
    }
}
