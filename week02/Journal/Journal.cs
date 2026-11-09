using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.IO;

public class Journal
{
    private List<Entry>_entries = new List<Entry>();

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

    public void SaveToFile(string file)
    {
        using(StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                // separate fields with a special character like ~|~ so we can split them apart when loading
                outputFile.WriteLine($"{entry._date}~|~{entry._promptText}~|~{entry._entryText}");
            }
        }
    }   

    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            string[] lines = File.ReadAllLines(file);
            _entries.Clear();  // clear current list before loading

            foreach (string line in lines)
            {
                string[] parts = line.Split("~|~");

                if (parts.Length == 3)
                {
                    Entry entry = new Entry();
                    entry._date = parts[0];
                    entry._promptText = parts[1];
                    entry._entryText = parts[2];

                    _entries.Add(entry);
                }
            }
        }
    }
}

