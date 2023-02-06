using System;

public class Prompt
{

string[] prompt = {"Was I inpired to choose the right today?", "Who was the most interesting person I interacted with today?", "Have I had the chance to share the Gospel or even a principle with someone today?", "What was the best part of my day?", "Did I say something different in a prayer?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?", "Did I smile to someone?"};

    public List<string> _prompt = new List<string>();

    public Prompt()
    {

    }

    public void Display()
    {
        var random = new Random();
        int index = random.Next(_prompt.Count);
        String Prompt = _prompt[index];
        Console.WriteLine($"\n{_prompt}");
    }

    public string GetPrompt()
    {
        var random = new Random();
        int index = random.Next(_prompt.Count);
        string Prompt = prompt[index];
        
        return Prompt;
    }
}