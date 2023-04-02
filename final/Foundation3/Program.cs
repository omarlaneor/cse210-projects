using System;

class Program
{
    static void Main(string[] args)
    {
        // Create some events
        Event event1 = new Event("Concert in Simón Bolívar park", "A concert in the park with some bands from the city.", new DateTime(2023, 4, 15), new DateTime(2023, 4, 15, 19, 0, 0), new Address("Ave. Street 53rd and Ave. Esmeralda #s/n", "Bogotá", "Colombia"));
        Conference conference1 = new Conference("Marine Life Conference", "Conference on technological advances that will help clean up pollution in the seas and preserve marine life.", new DateTime(2023, 4, 22), new DateTime(2023, 4, 22, 9, 0, 0), new Address("Cl. 135 #No. 53 - 57", "Barranquilla", "Colombia"), "Mitchell Bravestone", 250);
        Reception reception1 = new Reception("Wedding Reception", "Wedding reception for the couple Princess Peach and Mario Bross.", new DateTime(2023, 5, 7), new DateTime(2023, 5, 7, 17, 0, 0), new Address("Ave. Americas 4 - 84", "San Andrés and Providence", "Colombia"), "rsvp@gmail.com");
        OutdoorMeeting meeting1 = new OutdoorMeeting("Family Roast", "Family reunion for Baby Shower celebration.", new DateTime(2023, 5, 20), new DateTime(2023, 5, 20, 12, 0, 0), new Address("Cra. 19 # 10N-43", "Quindío", "Colombia"), "Sunny");

        // Show details of each event
        Console.WriteLine(event1.CompleteDetails());
        Console.WriteLine();
        Console.WriteLine(conference1.CompleteDetails());
        Console.WriteLine();
        Console.WriteLine(reception1.CompleteDetails());
        Console.WriteLine();
        Console.WriteLine(meeting1.CompleteDetails());
        Console.WriteLine();
    }
}
