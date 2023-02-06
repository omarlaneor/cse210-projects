using System;

public class Entry
{
    public string _entryNumber = "";
    public string _dateTime = "";
    public string _prompt = "";
    public string _entry = "";
    public string _file = "";


    public Entry()
    {
    }

    public void Display()
    {
        Console.WriteLine($"\n#: {_entryNumber}");
        Console.WriteLine($"Date: {_dateTime}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Entry: {_entry}");
    }

}