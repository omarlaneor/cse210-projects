public class ReflectingActivity : Activity{
   
    public ReflectingActivity() : base(){
        _name = "Reflecting";
        _duration = 0;
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience." + "\n" + "This will help you recognize the power you have and how you can use it in other aspects of your life.";
        
    }

    public string GetRandomPrompt()
    {
        List<string> prompts = new List<string>()
        {
            "Think of a time when you hugged someone.",
            "Think of a time when you smiled with someone you didn't know.",
            "Think of a time when you helped someone you didn't know and who really needed it.",
            "Think about a time when you shared your testimony of Jesus Christ with someone."
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
    public string GetRandomQuestion()
    {
        List<string> questions = new List<string>()
        {
            "How did you feel?",
            "What do you think you can do to improve the way you felt?",
            "Do you think your day has changed from what you did?",
            "How could you help other people to have this same experience?",
            "Was it difficult?"
        };
        Random random = new Random();
        int index = random.Next(questions.Count);
        string randQuest = questions[index];
        questions.Remove(randQuest);
        return randQuest;
        }

    public void DisplayRandomQuestion(){
        string randQuest = GetRandomQuestion();
        Console.WriteLine(randQuest);
        }

    public void  RunActivity(){
        Console.WriteLine("Consider the following prompt:" + "\n" + "When you have something in mind, press Enter to continue.");
        Console.WriteLine("");

        DisplayRandomPrompt();
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Now, ponder on each of the following questions as they related to these experiences: ");
        Console.WriteLine("");
        Console.Clear();

        for (int i = 5; i > 0; i--){
            Console.Write($"You may begin in {i} seconds.");
            Thread.Sleep(1000); 
            Console.Clear();   
            }

        Console.Clear();

        GetDuration(_duration);
        DateTime currentTime = DateTime.Now;
        while(currentTime < _endTime)
        {
            Console.Write(">");
            DisplayRandomQuestion();
            GetAnimation();
            currentTime = DateTime.Now;
            Console.WriteLine("");
        }
                
    }
}