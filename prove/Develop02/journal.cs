using System.Collections.Generic;
using System.IO;
 
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
 
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
 
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
 
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
    }
 
    public void LoadFromFile(string filename)
    {
        _entries.Clear();
 
        string[] lines = File.ReadAllLines(filename);
 
        foreach (string line in lines)
        {
            if (string.IsNullOrWhiteSpace(line))
            {
                continue;
            }
 
            // Split into 3 parts max so entry text can contain "|" without breaking everything
            string[] parts = line.Split('|', 3);
 
            Entry entry = new Entry();
            entry._date = parts.Length > 0 ? parts[0] : "";
            entry._promptText = parts.Length > 1 ? parts[1] : "";
            entry._entryText = parts.Length > 2 ? parts[2] : "";
 
            _entries.Add(entry);
        }
    }
}