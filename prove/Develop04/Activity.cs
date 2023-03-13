using System;

public class Activity{
    protected string _name;
    protected int _duration;
    protected string _description;
    protected DateTime _endTime;

    public Activity()
    {}
   
    public void GetAnimation(){
        List<string> animationStrings = new List<string>();

        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);
        while (DateTime.Now < endTime){
            foreach (string s in animationStrings)
            {
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
            }   
        }
    }

    public void GetDuration(int duration){
        DateTime startTime = DateTime.Now;
        _endTime = startTime.AddSeconds(duration);
    }

    public void StartMessage()
   {    Console.Write($"Loading {_name} activity ");
        GetAnimation();
        Console.Clear();

        Console.WriteLine($"Welcome to the {_name} activity.");
        Console.WriteLine("");

        Console.WriteLine($"{_description}");
        Console.WriteLine("");

        Console.WriteLine("How long would you like to participate? (Please, enter a number for your answer in seconds):");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();

        Console.Write("Loading ");
        GetAnimation();
        Console.Clear();

        Console.WriteLine("Get Ready...");
        Thread.Sleep(2700);
        Console.Clear();
   }

   public void EndMessage()
   {
    Console.WriteLine($"Thank you for completing the {_name} acitivty!");
    Console.WriteLine($"We really hope you enjoyed and relaxed with it!");
    Console.WriteLine($"We hope to see you soon again!");
   }
}