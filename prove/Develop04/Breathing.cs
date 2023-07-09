class Breathing : Activity
{
    public Breathing() : base()
    {
        _activityName = "Breathing";
        _description = "This activity will help you relax by walking you through a 4-7-8 breathing technique.";
        _instructions = "Clear your mind and focus on your breathing.";
    }

    public void StartBreathingActivity()
    {
        // Creativity:  Instead of a simple "breathe in/breathe out" exercise, I changed it to the 4-7-8 Breathing Technique
        Console.Clear();
        base.InitializeActivity("GetReady");

        while (_startTime < _endTime)
        {

            // Exhale 8 Seconds
            Console.Write("Breath out completely through your mouth...");
            base.ShowCountdown(8);
            Console.WriteLine("\n");

            // Inhale 4 Seconds
            Console.Write("Breath in through your nose...");
            base.ShowCountdown(4);
            Console.WriteLine("\n");

            //Hold for 7 Seconds
            Console.Write("Hold your breath...");
            base.ShowCountdown(7);
            Console.WriteLine("\n");

            _startTime = DateTime.Now;
        }
    }
}