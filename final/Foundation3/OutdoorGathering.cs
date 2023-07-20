class OutdoorGathering : Event
{
    public string Weather { get; set; }

    public override string GenerateFullDetails()
    {
        string details = GenerateStandardDetails();
        details += "Type: Outdoor Gathering\n";
        details += "Weather: " + Weather + "\n";

        return details;
    }
}