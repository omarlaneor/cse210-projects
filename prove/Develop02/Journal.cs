using System;

public class Journal
{
    public List<Entry> _journal = new List<Entry>();

    private string _userFileName;

    public Journal()
    {
    }

    public void Display()
    {
        Console.WriteLine("\nJournal Entries");
        foreach (Entry entry in _journal)
        {
            entry.Display();
        }
        Console.WriteLine("\nEnd\n");
    }

    public void CreateFile()
    {
        Console.Write("Please, enter your file name:? ");
        string userInput = Console.ReadLine();
        _userFileName = userInput + ".txt";

        if (!File.Exists(_userFileName))
        {
            File.CreateText(_userFileName);
            Console.Write($"\n{_userFileName} has been created! \n");
            Console.Write("Entries saved.\n");
            SaveFile(_userFileName);
        }
        else
        {
            Console.Write($"\n{_userFileName} already exits.\n");
            Console.Write("Entries added.\n");
            AppendFile(_userFileName);
        }
    }
    public void SaveFile(string _userFileName)
    {
        using (StreamWriter outputFile = new StreamWriter(_userFileName))
        {
            foreach (Entry entry in _journal)
            {
                outputFile.WriteLine($"{entry._entryNumber}; {entry._dateTime}; {entry._prompt}; {entry._entry}");
            }
        }
    }

    public void AppendFile(string _userFileName)
    {
        using (StreamWriter outputFile = new StreamWriter(_userFileName, append: true))
        {
            foreach (Entry entry in _journal)
            {
                outputFile.WriteLine($"{entry._entryNumber}; {entry._dateTime}; {entry._prompt}; {entry._entry}");
            }
        }
    }

    public void LoadFile()
    {
        Console.Write("Please, enter your file name:? ");
        string userInput = Console.ReadLine();
        _userFileName = userInput + ".txt";

        if (File.Exists(_userFileName))
        {
            List<string> readText = File.ReadAllLines(_userFileName).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();
            foreach (string line in readText)
            {
                string[] entries = line.Split("; ");

                Entry entry = new Entry();

                entry._entryNumber = entries[0];
                entry._dateTime = entries[1];
                entry._prompt = entries[2];
                entry._entry = entries[3];

                _journal.Add(entry);
            }
        }
    }


}
