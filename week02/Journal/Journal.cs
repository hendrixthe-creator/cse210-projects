using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

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
            entry.Dispaly();
        }
    }

    public void SaveToFile(string file)
    {
        
    }   

    public void LoadFromFile(string file)
    {
        
    }
}

