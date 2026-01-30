using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("How to Learn C# Fast", "Code Academy", 540);
        Video video2 = new Video("Learn OOP from scratch", "Dev Simplified", 420);
        Video video3 = new Video("Become a C# expert", "Danki Code", 615);

        // Add comments to video1
        video1.AddComment(new Comment("Francisco", "Finally understood constructors. Thanks!"));
        video1.AddComment(new Comment("Anna", "Very clear explanation."));
        video1.AddComment(new Comment("John", "Can you do one about interfaces too?"));

        // Add comments to video2
        video2.AddComment(new Comment("Mary", "Abstraction is much clearer now."));
        video2.AddComment(new Comment("Lucas", "Great examples!"));
        video2.AddComment(new Comment("Beatriz", "This helped my assignment a lot."));

        // Add comments to video3
        video3.AddComment(new Comment("Pedro", "Loved the tip about small methods."));
        video3.AddComment(new Comment("Sofia", "Nice and practical."));
        video3.AddComment(new Comment("Daniel", "Could you cover naming conventions more?"));

        // Put videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display details
        foreach (Video video in videos)
        {
            Console.WriteLine("========================================");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length (seconds): {video.GetLengthSeconds()}");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.GetCommenterName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}
