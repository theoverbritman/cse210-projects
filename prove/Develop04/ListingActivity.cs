using System;
using System.Collections.Generic;
 
public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
 
    private Random _random = new Random();
 
    public ListingActivity()
        : base(
            "Listing",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
        )
    {
    }
 
    public void Run()
    {
        DisplayStartingMessage();
 
        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
        Console.WriteLine("Start listing items. Press Enter after each item.");
        Console.WriteLine();
 
        int count = 0;
        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);
 
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }
 
        Console.WriteLine();
        Console.WriteLine($"You listed {count} items!");
 
        DisplayEndingMessage();
    }
}