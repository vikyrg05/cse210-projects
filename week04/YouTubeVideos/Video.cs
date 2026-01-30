using System;
using System.Collections.Generic;

public class Video
{
    //Attributes
    public string Title { get; set; }
    public string Author { get; set; }
    public int DurationInSeconds { get; set; }

    //List of Comments
    public List<Comment> Comments { get; set; }

    //Constructor
    public Video(string title, string author, int durationInSeconds)
    {
        Title = title;
        Author = author;
        DurationInSeconds = durationInSeconds;
        Comments = new List<Comment>();
    }

    //Method get number of comments
    public int GetNumberOfComments()
    {
        return Comments.Count;
    }
}