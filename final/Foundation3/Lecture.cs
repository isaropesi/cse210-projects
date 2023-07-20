class Lecture : Event
{
    public string Speaker { get; set; }
    public int Capacity { get; set; }

    public override string GenerateFullDetails()
    {
        string details = GenerateStandardDetails();
        details += "Type: Lecture\n";
        details += "Speaker: " + Speaker + "\n";
        details += "Capacity: " + Capacity + "\n";

        return details;
    }
}