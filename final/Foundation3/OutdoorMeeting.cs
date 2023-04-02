using System;

// Class for outdoor meetings, which inherits from Event
class OutdoorMeeting : Event
{
    // Additional private member variable for weather declaration
    private string weather;

    // Constructor to initialize member variables
    public OutdoorMeeting(string title, string description, DateTime date, DateTime hour, Address address, string weather)
        : base(title, description, date, hour, address)
    {
        this.weather = weather;
    }

    // Method to get a string with the full details of the outdoor meeting
    public override string CompleteDetails()
    {
        return $"Event Type: {GetType().Name}\n{base.CompleteDetails()}\nPredicted weather: {weather}";
    }

}

