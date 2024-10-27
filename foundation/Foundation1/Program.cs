using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Creating videos
        Video video1 = new Video("How to kickflip", "Tony", 600);
        Video video2 = new Video("Minecraft", "Steve", 900);
        Video video3 = new Video("Piano for the soul", "Sam", 1200);

        // Adding comments to video1
        video1.AddComment(new Comment("David", "This is really helpful!"));
        video1.AddComment(new Comment("Emma", "Great explanation."));
        video1.AddComment(new Comment("Frank", "I learned a lot from this video."));

        // Adding comments to video2
        video2.AddComment(new Comment("George", "Moreeeeee."));
        video2.AddComment(new Comment("Hannah", "Glad you made it to the nether."));
        video2.AddComment(new Comment("Isla", "Wow, You can play well!"));

        // Adding comments to video3
        video3.AddComment(new Comment("Jack", "My soul feels restored"));
        video3.AddComment(new Comment("Katie", "Perfect to study to."));
        video3.AddComment(new Comment("Liam", "This is the best backgroung music."));

        // Adding videos to list and displaying each one
        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (var video in videos)
        {
            video.Display();
        }
    }
}