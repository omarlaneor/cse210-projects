using System;
using System.Collections.Generic;

class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int DurationInSeconds { get; set; }
    private List<Comment> comments = new List<Comment>();

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return comments.Count;
    }

    public void PrintDetails()
    {
        Console.WriteLine("\n Title: " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("Duration (seconds): " + DurationInSeconds);
        Console.WriteLine("Comment count: " + GetCommentCount());
        Console.WriteLine("Comments:");
        foreach (Comment comment in comments)
        {
            Console.WriteLine("- " + comment.Author + ": " + comment.Text);
        }
        Console.WriteLine();
    }
}

