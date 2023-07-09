
class Reflecting : Activity
{
    private List<string> _experiencePrompts = new List<string>{
        " --- Think of a time when you accomplished something you thought you couldn't ---",
        " --- Think of a time when you worked hard for something you wanted ---",
        " --- Think of a time when you stood up for something you believed in ---",
        " --- Think of a time when you went out of your way to make someone smile ---",
        " --- Think of a time when you were a peacemaker ---",
        " --- Think of a time when you showed someone kindness or support",
    };

    private List<string> _reflectionPrompts = new List<string>{
        "> What is your favorite thing about this experience?",
        "> What did you learn about yourself from this experience? ",
        "> What was different about this experience than others? ",
        "> What did you learn about yourself from this experience? ",
        "> How can you apply this experience into future experiences? ",
        "> What did this experience teach you about strength? ",
        "> What did this experience teach you about resilience? ",
    };

    private string _userChoice;

    private bool _userReady = false;

    public Reflecting() : base()
    {
        _activityName = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown stength and resilience. This will hel you recognize the power you have and how you can use it in other aspects of your life.";
        _instructions = "You will be given guidance to think about a past experience. Use that experience to answer the later questions to yourself. ";
    }

    public string GetExperiencePrompt()
    {
        Random r = new Random();
        int index = r.Next(_experiencePrompts.Count());
        return _experiencePrompts[index];
    }

    public string GetReflectionPrompt()
    {
        Random r = new Random();
        int index = r.Next(_reflectionPrompts.Count());
        return _reflectionPrompts[index];
    }

    public void StartReflectingActivity()
    {
        Console.Clear();
        base.GetReady(7);

        // Creativity: Refreshes the Question if user doesn't like their original question.
        while (_userReady == false)
        {
            Console.Clear();
            Console.WriteLine("Consider the following prompt:\n");
            Console.WriteLine(this.GetExperiencePrompt());
            Console.WriteLine();
            Console.Write("When you have something in mind, press enter to continue or R to refresh the question: ");
            _userChoice = Console.ReadLine();

            if (_userChoice == "")
            {
                _userReady = true;
                continue;
            }

            else if (_userChoice.ToUpper() == "R")
            {
                continue;
            };
        }

        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");
        base.InitializeActivity("Countdown");
        Console.Clear();
        while (_startTime < _endTime)
        {

            Console.Write(this.GetReflectionPrompt());
            base.ShowSpinner(7);
            Console.WriteLine("\n");
            _startTime = DateTime.Now;
        }



    }
}