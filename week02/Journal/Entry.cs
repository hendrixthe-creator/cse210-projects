using System;
public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Dispaly()
    {
        Console.WriteLine($"Date:{_date}");
        Console.WriteLine($"Prompt:{_promptText}");
        Console.WriteLine($"Resposne:{_entryText}");
    }
}