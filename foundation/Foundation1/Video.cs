using System;
using System.Collections.Generic;

public class Video
{
    // Fields (class-level member variables)
    private string _title;
    private string _author;
    private int _length; // in seconds
    private List<Comment> _comments;

    // Constructor
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    // Method to add a comment
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Method to get the number of comments
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    // Method to get display text
    public string GetDisplayText()
    {
        string timeFormatted = $"{_length / 60}:{_length % 60:D2}"; // Format length as minutes:seconds
        return $"Title: {_title}\nAuthor: {_author}\nLength: {timeFormatted} minutes\nNumber of Comments: {GetNumberOfComments()}";
    }

    // Method to get the list of comments
    public List<Comment> GetComments()
    {
        return _comments;
    }
}
