using System;

// Class for conferences, which inherits from Event
class Conference : Event
{
    // Additional private member variables for speaker name and ability
    private string speakerName;
    private int speakerCapacity;

    // Constructor to initialize member variables
    public Conference(string title, string description, DateTime date, DateTime hour, Address address, string speakerName, int speakerCapacity)
        : base(title, description, date, hour, address)
    {
        this.speakerName = speakerName;
        this.speakerCapacity = speakerCapacity;
    }

    // Method to get a string with the full details of the conference
    public override string CompleteDetails()
    {
        return $"Event Type: {GetType().Name}\n{base.CompleteDetails()}\nSpeaker's Name: {speakerName}\nAuditorium Capacity: {speakerCapacity}";
    }
}


