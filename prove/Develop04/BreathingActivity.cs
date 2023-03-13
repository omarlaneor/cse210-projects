public class BreathingActivity : Activity{
    public BreathingActivity() : base(){
        _name = "Breathing";
        _duration = 0;
        _description = "\n" + "This activity will help you relax by walking your through breathing in and out slowly."+ "\n" + "Clear your mind and focus on your breathing!";
    }

    public void Breathe()
    {
     for(int i = 5; i >= 0; i--)
       {
        Console.Write($"\rBreathe in... {i}");
        Thread.Sleep(1200);
       }
        Console.WriteLine(""); 
        
        for(int i = 5; i >= 0; i--)
       {
        Console.Write($"\rBreathe out... {i}");
        Thread.Sleep(1200);
       }
        Console.WriteLine("");
    }

    public void RunActivity()
    {
        GetDuration(_duration);
        DateTime currentTime = DateTime.Now;
        while(currentTime < _endTime)
        {
            Breathe();
            currentTime = DateTime.Now; 
            Console.WriteLine("");
        }
    }
}
