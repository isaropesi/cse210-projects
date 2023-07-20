using System;

class Event
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public string Time { get; set; }
    public Address Address { get; set; }

    public virtual string GenerateStandardDetails()
    {
        string details = "Standard Details:\n";
        details += "Title: " + Title + "\n";
        details += "Description: " + Description + "\n";
        details += "Date: " + Date.ToShortDateString() + "\n";
        details += "Time: " + Time + "\n";
        details += "Address: " + Address.GetFullAddress() + "\n";

        return details;
    }

    public virtual string GenerateFullDetails()
    {
        return GenerateStandardDetails();
    }

    public virtual string GenerateShortDescription()
    {
        string description = "Short Description:\n";
        description += "Type: Event\n";
        description += "Title: " + Title + "\n";
        description += "Date: " + Date.ToShortDateString() + "\n";

        return description;
    }
}