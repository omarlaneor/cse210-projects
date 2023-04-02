using System;

// Base Class for Events
class Event
{
    // Private member variables for event title, description, date, time, and address
    private string title;
    private string description;
    private DateTime date;
    private DateTime hour;
    private Address address;

    // Constructor to initialize member variables
    public Event(string title, string description, DateTime date, DateTime hour, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.hour = hour;
        this.address = address;
    }

    // Method to get a string with the standard details of the event
    public virtual string StandardDetails()
    {
        return $"Title: {title}\nDescription: {description}\nDate: {date.ToShortDateString()}\nHour: {hour.ToShortTimeString()}\nAddress: {address}";
    }

    // Method to get a string with the full details of the event
    public virtual string CompleteDetails()
    {
        return StandardDetails();
    }

    // Method to get a string with a brief description of the event
    public virtual string BriefDescription()
    {
        return $"{GetType().Name}: {title} - {date.ToShortDateString()}";
    }
}

