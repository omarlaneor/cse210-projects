
class Program
{
    static void Main(string[] args)
    {
        int quit = 0;

        while (quit != 4){
            Console.Clear();
            Console.WriteLine("\n" + "Welcome to the Mindfulness Activity!");
            Console.WriteLine("Please, select one of our Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Listing Activity");
            Console.WriteLine("3. Start Reflecting Activity");
            Console.WriteLine("4. Quit");
            quit = int.Parse(Console.ReadLine());
            Console.Clear();

            if (quit == 1)
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.StartMessage();
                breathing.RunActivity();
                breathing.EndMessage();
            }

            else if (quit == 2)
            {
                ListingActivity listing = new ListingActivity();
                listing.StartMessage();
                listing.RunActivity();
                listing.EndMessage();
            } 

            else if (quit == 3)
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.StartMessage();
                reflecting.RunActivity();
                reflecting.EndMessage();
            }

            else
            {
                Console.WriteLine("Thank you! We hope you've enjoyed it!");
                break;
            }
        }
    }
}