using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {
        while (true)
        {
            Console.WriteLine($"\nCurrent Score: {_score}");
            ShowMenu();

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoals(); break;
                case "3": RecordEvent(); break;
                case "4": SaveGoals(); break;
                case "5": LoadGoals(); break;
                case "6": return;
                default: Console.WriteLine("Invalid choice."); break;
            }
        }
    }

    public void ShowMenu()
    {
        Console.WriteLine("\nMenu:");
        Console.WriteLine("1. Create Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Record Event");
        Console.WriteLine("4. Save Goals");
        Console.WriteLine("5. Load Goals");
        Console.WriteLine("6. Quit");
        Console.Write("Select choice: ");
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nGoal Types:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Select type: ");
        string type = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string desc = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            _goals.Add(new SimpleGoal(name, desc, points));
        }
        else if (type == "2")
        {
            _goals.Add(new EternalGoal(name, desc, points));
        }
        else if (type == "3")
        {
            Console.Write("Target count: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus points: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }
    }

    public void ListGoals()
    {
        Console.WriteLine("\nGoals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
        }
    }

    public void RecordEvent()
    {
        ListGoals();
        Console.Write("Select goal number: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index < 0 || index >= _goals.Count)
        {
            Console.WriteLine("Invalid selection.");
            return;
        }

        int earned = _goals[index].RecordEvent();
        _score += earned;

        Console.WriteLine($"You earned {earned} points!");
    }

    public void SaveGoals()
    {
        Console.Write("Enter filename: ");
        string file = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(file))
        {
            writer.WriteLine(_score);

            foreach (Goal g in _goals)
            {
                writer.WriteLine(g.GetSaveData());
            }
        }

        Console.WriteLine("Goals saved.");
    }

    public void LoadGoals()
    {
        Console.Write("Enter filename: ");
        string file = Console.ReadLine();

        if (!File.Exists(file))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _goals.Clear();
        string[] lines = File.ReadAllLines(file);

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');

            if (parts[0] == "Simple")
            {
                _goals.Add(new SimpleGoal(
                    parts[1], parts[2],
                    int.Parse(parts[3]),
                    bool.Parse(parts[4])));
            }
            else if (parts[0] == "Eternal")
            {
                _goals.Add(new EternalGoal(
                    parts[1], parts[2],
                    int.Parse(parts[3])));
            }
            else if (parts[0] == "Checklist")
            {
                _goals.Add(new ChecklistGoal(
                    parts[1], parts[2],
                    int.Parse(parts[3]),
                    int.Parse(parts[4]),
                    int.Parse(parts[5]),
                    int.Parse(parts[6])));
            }
        }

        Console.WriteLine("Goals loaded.");
    }
}
