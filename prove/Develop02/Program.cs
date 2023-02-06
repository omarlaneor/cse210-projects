using System;

class Program
{
    static void Main(string[] args)
    {
        int[] optionalNumbers = {1, 2, 3, 4, 5};
        int option = 0;
        Journal journal = new Journal();
        Prompt jornalNew = new Prompt();

        while (option != 5)
        {
            option = Choices();
            switch (option)
            {
                case 1:
                    String dateInfo = GetDateTime();
                    String prompt = jornalNew.GetPrompt();

                    Entry entry = new Entry();
                    entry._dateTime = dateInfo;
                    entry._prompt = prompt;

                    Console.Write($"{prompt}\n");
                    String userEntry = Console.ReadLine();
                    entry._entry = userEntry;

                    journal._journal.Add(entry);
                    break;

                case 2:
                    journal.Display();
                    break;

                case 3:
                    journal.LoadFile();
                    break;

                case 4:
                    journal.CreateFile();
                    break;

                case 5:
                    Console.WriteLine("\nThank you!\nGood bye");
                    break;

                default:
                    Console.WriteLine($"\nInvalid option.");
                    break;
            }
        }
    }

    static int Choices()
        {String choices = @"
Please select one of the following choices:

1. Write
2. Display
3. Load
4. Save
5. Quit

Please, select an option to continue: ";

        Console.Write(choices);
        String userInput = Console.ReadLine();
        int option = 0;

        try
        {
        option = int.Parse(userInput);
        }
        catch (FormatException)
        {
        option = 0;
        }
        catch (Exception exception)
        {
        Console.WriteLine(
            $"Error: {exception.Message}");
        }
        return option;
        }

    static string GetDateTime()
    {
        DateTime now = DateTime.Now;
        string currentDateTime = now.ToString("F");
        return currentDateTime;
    }
    static void AddEntry()
    {
        string MyJournalFile = "MyJournal.txt";
        File.AppendAllText(MyJournalFile, "");
    }
}