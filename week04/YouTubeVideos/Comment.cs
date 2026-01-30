using System;
public class Comment
{
    //Attributes
    public string AuthorName { get; set; }
    public string Text { get; set; }

    //Constructor
    public Comment(string authorName, string text)
    {
        AuthorName = authorName;
        Text = text;
    }
}