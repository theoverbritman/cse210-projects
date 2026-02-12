using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video("C# Basics", "CodeMaster", 600);
        v1.AddComment(new Comment("Alice", "Great tutorial!"));
        v1.AddComment(new Comment("Bob", "Very helpful."));
        v1.AddComment(new Comment("Sam", "Thanks for this."));
        videos.Add(v1);

        Video v2 = new Video("OOP Explained", "DevPro", 800);
        v2.AddComment(new Comment("Jane", "Now I understand polymorphism."));
        v2.AddComment(new Comment("Mike", "Clear explanation."));
        v2.AddComment(new Comment("Chris", "Awesome."));
        videos.Add(v2);

        Video v3 = new Video("Gaming Review", "GameGuy", 1200);
        v3.AddComment(new Comment("Luna", "Love this game."));
        v3.AddComment(new Comment("Tom", "Nice review."));
        v3.AddComment(new Comment("Eli", "Buying it now."));
        videos.Add(v3);

        foreach (Video v in videos)
        {
            v.DisplayVideoInfo();
        }
    }
}
