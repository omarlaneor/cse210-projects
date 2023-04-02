using System;

// Examples of use
public class Program
{
    public static void Main()
    {
    Activity activity1 = new Run(new DateTime(2022, 3, 15), 45, 10.5);
    Console.WriteLine(activity1.GetSummary());
    Activity activity2 = new Bike(new DateTime(2022, 3, 20), 60, 25);
    Console.WriteLine(activity2.GetSummary());

    Activity activity3 = new Swimming(new DateTime(2022, 3, 25), 30, 10);
    Console.WriteLine(activity3.GetSummary());
    }
}
