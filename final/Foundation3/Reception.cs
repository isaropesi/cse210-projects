class Reception : Event
{
    public string RSVPEmail { get; set; }

    public override string GenerateFullDetails()
    {
        string details = GenerateStandardDetails();
        details += "Type: Reception\n";
        details += "RSVP Email: " + RSVPEmail + "\n";

        return details;
    }
}