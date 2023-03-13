public class ListingActivity : Activity{

    public ListingActivity () : base(){
        _name = "Listing";
        _duration = 0;
        _description = "This activity will help you reflect on the good things in your" + "\n" + "life by having you list as many things as you can in a certain area.";
    }

    public string GetRandomPrompt()
    {
        List<string> prompts = new List<string>()
        {
            "Have you prayed to give thanks for your friends today?",
            "Who are the people you have helped this week?",
            "Who have you called to say hello?",
            "What are your personal strengths?",
            "What service opportunities have you had today?",
            "Who are some of your personal heroes?",
            "What scripture would make you remember today?",
            "Who are the people you appreciate?"
        };
        Random random = new Random();
        int index = random.Next(prompts.Count);
        string randPrompt = prompts[index];
        prompts.Remove(randPrompt);
        return randPrompt;
        
        }

    public void DisplayRandomPrompt(){
        string randPrompt = GetRandomPrompt();
        Console.WriteLine(randPrompt);
    }
    
    public void RunActivity()
    {   
        int items = 0;
        GetDuration(_duration);
        DisplayRandomPrompt();
        DateTime currentTime = DateTime.Now;
        while(currentTime < _endTime)
        {   
            Console.Write(">");
            Console.ReadLine();
            items += 1;
            currentTime = DateTime.Now; 
            
        }
        Console.WriteLine($"Great! You've entered {items} items!");
    }
}