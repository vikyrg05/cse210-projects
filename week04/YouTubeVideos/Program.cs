using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Video 1
        Video video1 = new Video("learning C#", "Carlos Tech", 600);
        video1.Comments.Add(new Comment("Ana", "Very good video"));
        video1.Comments.Add(new Comment("Luis", "It helped me a lot"));
        video1.Comments.Add(new Comment("Maria", "Excellent explanation"));

        //Video2
        Video video2 = new Video("Object Oriented Programming", "CodeMaster", 900);
        video2.Comments.Add(new Comment("Pedro", "Now I understand classes"));
        video2.Comments.Add(new Comment("Sofia", "Very clear explanation"));
        video2.Comments.Add(new Comment("Jorge", "Good content"));

        //Video 3
        Video video3 = new Video("Abstraction in Programming", "DevAcademy", 750);
        video3.Comments.Add(new Comment("Laura", "Excellent topic"));
        video3.Comments.Add(new Comment("Diego", "Very useful"));
        video3.Comments.Add(new Comment("Valeria", "Thanks for the explanation"));

        //List of videos
        List<Video> videos = new List<Video> { video1, video2, video3 };

        //Iterate and Show
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Duration (seconds): " + video.DurationInSeconds);
            Console.WriteLine("Number of comments: " + video.GetNumberOfComments());
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine(" - " + comment.AuthorName + ": " + comment.Text);
            }

            Console.WriteLine();
        }

        //Final Message
        Console.WriteLine("All videos have been displayed!");
    }
}