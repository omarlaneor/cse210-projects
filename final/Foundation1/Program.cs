using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // create 3-4 videos and add comments to each
        Video video1 = new Video()
        {
            Title = "I Knew I Loved You",
            Author = "Savage Garden",
            DurationInSeconds = 229
        };
        video1.AddComment(new Comment() {Author = "Rushell Reid", Text = "It's 2023 and this song is still a hit."});
        video1.AddComment(new Comment() {Author = "Jonathan LI", Text = "I dedicated this song to my future wife 23 years ago. Long story short, I fell in love with her before we even met. This song translated my feelings for her. Such a beautiful song. Today we celebrate our 19th wedding anniversary."});
        video1.AddComment(new Comment() {Author = "ClickorTrap", Text = "This song never gets old. One of the best songs ever made 👍."});
        videos.Add(video1);

        Video video2 = new Video()
        {
            Title = "Sugar",
            Author = "Maroon 5",
            DurationInSeconds = 301
        };
        video2.AddComment(new Comment() {Author = "Carolina Ceballos Longa", Text = "Who else is having a “good old songs” marathon?"});
        video2.AddComment(new Comment() {Author = "Nash Kayosa", Text = "Am still in love with song ever since I was 17 years now 24 and the song still rocks in my ears always ❤❤"});
        video2.AddComment(new Comment() {Author = "Micah Ray", Text = "This is still probably my favorite music video. There's so much joy and surprise on everyone's faces :)"});
        videos.Add(video2);

        Video video3 = new Video()
        {
            Title = "Shape of You",
            Author = "Ed Sheeran",
            DurationInSeconds = 263
        };
        video3.AddComment(new Comment() {Author = "J. Haber", Text = "2 April 2023 Lets see how many legends are listening to this masterpiece. By far one of the most popular songs ever even after 6 year’s."});
        video3.AddComment(new Comment() {Author = "Leops ft Who", Text = "It's a traditional to come back to this once in a while in 2023 because it's just so beautiful"});
        video3.AddComment(new Comment() {Author = "Nick Fenton", Text = "Almost to 6 BILLION views! Amazing! Let's keep it up! It won't be long before it hits 6 billion."});
        video3.AddComment(new Comment() {Author = "Rahul Pable", Text = "4 Years passed! this song is still in my playlist!! 💗"});
        videos.Add(video3);

        // print details of each video and its comments
        foreach (Video video in videos)
        {
            video.PrintDetails();
        }

        Console.ReadKey();
    }
}