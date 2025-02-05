using System;
using System.Globalization;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Console.WriteLine("");

        List<Video> videos = new List<Video>();



        Video videoOne = new Video("How to learn programming",  "Luis M.",120);
        videoOne.AddComment(new Comment("Zara Smith","Awesome tutorial!"));
        videoOne.AddComment(new Comment("john lil","good job.!"));
        videoOne.AddComment(new Comment("Sam ellis","very good"));

        Video videotwo = new Video("Python classes",  "Robert johnnson.",380);
        videotwo.AddComment(new Comment("Carlos P.","wow!"));
        videotwo.AddComment(new Comment("Pedro Barrio","Very helpul."));
        videotwo.AddComment(new Comment("Marry Jane","Amazing job"));

        videos.Add(videoOne);
        videos.Add(videotwo);

        foreach (var video in videos)
        {
       Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentAmount()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"- {comment._name}: {comment._text}");
            }
            Console.WriteLine(); // Blank line between videos
        }






    }
}