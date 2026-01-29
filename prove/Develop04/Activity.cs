using System;
using System.Collections.Generic;
using System.Threading;
 
public class Activity
{
    private string _name;
    private string _description;
    private int _duration;
 
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
 
    public int GetDuration()
    {
        return _duration;
    }
 
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
 
        string input = Console.ReadLine();
        _duration = int.Parse(input);
 
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.WriteLine();
    }
 
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed the {_name} Activity for {_duration} seconds.");
        ShowSpinner(3);
        Console.WriteLine();
    }
 
    public void ShowSpinner(int seconds)
    {
        List<string> frames = new List<string> { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
 
        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(frames[i]);
            Thread.Sleep(250);
            Console.Write("\b \b");
 
            i++;
            if (i >= frames.Count)
            {
                i = 0;
            }
        }
    }
 
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}