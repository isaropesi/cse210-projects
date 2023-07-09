using System;
using System.Diagnostics;
class Listing : Activity
{
    private List<string> _promptsList = new List<string>{
        " --- Who has been a positive influence in your life? ---",
        " --- What are your greatest strengths? ---",
        " --- When have you felt the love of the Savior this month? ---",
        " --- Who do you turn to for love and support? ---",
        " --- What are some things that make you smile? ---",
        " --- What blessings from Heavenly Father have you noticed this week? ---",
        " --- When do you feel closest to your Savior? ---",
    };

    private List<string> _responseList = new List<string>();

    // private string _userResponse;
    private Stopwatch sw = new Stopwatch();
    private double lastFrame;





    public Listing() : base()
    {
        _activityName = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _instructions = "You will be given a question to think about with multiple possible answers. Type each answer out in the space provided and hit 'enter' to submit. Submit as many answers as you can in the time provided.";
    }

    public string GetPrompt()
    {
        Random r = new Random();
        int index = r.Next(_promptsList.Count());
        return _promptsList[index];
    }

    private double deltaTime()
    {
        TimeSpan ts = this.sw.Elapsed;
        double firstFrame = ts.TotalMilliseconds;

        double dt = firstFrame - lastFrame;

        this.lastFrame = ts.TotalMilliseconds;

        return dt;
    }
    public void StartListingActivity()
    {
        Console.Clear();
        base.GetReady(6);

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine(this.GetPrompt());
        Console.WriteLine("You may begin in: ");
        base.ShowCountdown(6);
        Console.WriteLine("\n");

        this.sw.Start();
        double acc = 0.0;
        while (acc <= (_duration * 1000))
        {
            acc += this.deltaTime();
            if (!Console.KeyAvailable)
            {
                continue;
            }
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                Console.WriteLine("");
                Console.Write("> ");
                _responseList.Add("\n");
            }
            else
            {
                _responseList.Add(key.KeyChar.ToString());
            }
        }

        int lines = _responseList.Count(c => c == "\n");

        Console.WriteLine($"\r\nGreat! You listed {lines} items!");
    }
}