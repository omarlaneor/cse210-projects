using System;

// Class for receptions, which inherits from Event
class Reception : Event
{
    // Additional private member variable for RSVP email
    private string mailRSVP;

    // Constructor to initialize member variables
    public Reception(string title, string description, DateTime date, DateTime hour, Address address, string mailRSVP)
        : base(title, description, date, hour, address)
    {
        this.mailRSVP = mailRSVP;
    }

    // Method to get a string with the full details of the receipt
    public override string CompleteDetails()
    {
        return $"Event Type: {GetType().Name}\n{base.CompleteDetails()}\nRSVP e-mail: {mailRSVP}";
    }
}

