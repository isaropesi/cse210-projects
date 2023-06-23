using System.Timers;

public class Menu
{
    private Journal journal;
    private PromptGenerator promptGenerator;

    public Menu()
    {
        journal = new Journal();
        promptGenerator = new PromptGenerator();
    }

    public void ShowMenu()
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please, select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("4. Load");
        Console.WriteLine("3. Save");
        Console.WriteLine("5. Set a reminder to write");
        Console.WriteLine("6. Quit");
    }

    public void HandleChoice(int choice)
    {
        switch (choice)
        {
            case 1:
                WriteNewEntry();
                break;
            case 2:
                DisplayJournal();
                break;
            case 3:
                SaveJournal();
                break;
            case 4:
                LoadJournal();
                break;
            case 5:
                SetReminder();
                break;
            case 6:
                QuitProgram();
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }

    private void WriteNewEntry()
    {
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine($"{prompt}");
        Console.Write("> ");
        string response = Console.ReadLine();

        Entry entry = new Entry
        {
            Prompt = prompt,
            Response = response,
            Date = DateTime.Now
        };

        journal.AddEntry(entry);
    }

    private void DisplayJournal()
    {
        journal.DisplayEntries();
    }

    private void SaveJournal()
    {
        Console.Write("What is the filename? ");
        string fileName = Console.ReadLine();
        journal.SaveToFile(fileName);
        Console.WriteLine("Journal saved successfully.");
    }

    private void LoadJournal()
    {
        Console.Write("What is the filename? ");
        string fileName = Console.ReadLine();
        journal.LoadFromFile(fileName);
        Console.WriteLine("Journal loaded successfully.");
    }

    private void QuitProgram()
    {
        Console.WriteLine("Quiting the program...");
        Environment.Exit(0);
    }

    private void SetReminder()
    {
        Console.Write("Enter the interval in minutes for the reminder: ");
        int interval = int.Parse(Console.ReadLine());

        System.Timers.Timer timer = new System.Timers.Timer(interval * 60 * 1000); // Convert minutes to milliseconds
        timer.Elapsed += (sender, e) => WriteNewEntry();
        timer.AutoReset = true;
        timer.Enabled = true;

        Console.WriteLine($"Reminder set. You will be prompted to write a journal entry every {interval} minutes.");
    }
}