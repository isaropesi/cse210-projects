using System;

class Program
{
    private static List<Goal> goals = new List<Goal>();
    private static int score = 0;

    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine($"You have {score} points.");
            Console.WriteLine();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Exit");
            Console.WriteLine();

            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    CreateNewGoal();
                    break;
                case "2":
                    ListGoals();
                    break;
                case "3":
                    SaveData();
                    break;
                case "4":
                    LoadData();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    private static void CreateNewGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple goal");
        Console.WriteLine("2. Eternal goal");
        Console.WriteLine("3. Checklist goal");
        Console.WriteLine();

        Console.Write("Which type of goal would you like to create? ");
        string goalType = Console.ReadLine();
        Console.Write("Whats is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int goalScore = int.Parse(Console.ReadLine());

        switch (goalType)
        {
            case "1":
                goals.Add(new SimpleGoal { Description = goalDescription, Name = goalName, Points = goalScore });
                break;
            case "2":
                goals.Add(new EternalGoal { Description = goalDescription, Name = goalName, PointsPerCompletion = goalScore });
                break;
            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int numberAccomplishToBonus = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int goalBonus = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal { Description = goalDescription, Name = goalName, PointsPerCompletion = goalScore, TargetCount = numberAccomplishToBonus, BonusPoint = goalBonus });
                break;
            default:
                Console.WriteLine("Invalid goal type. Please try again.");
                break;
        }
    }

    private static void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Description}");
        }
        Console.WriteLine();

        Console.Write("Enter goal number: ");
        int goalNumber = int.Parse(Console.ReadLine()) - 1;

        if (goalNumber < 0 || goalNumber >= goals.Count)
        {
            Console.WriteLine("Invalid goal number. Please try again.");
            return;
        }

        Goal goal = goals[goalNumber];
        if (goal is ChecklistGoal checklistGoal)
        {
            if (checklistGoal.IsCompleted)
            {
                return;
            }
            if (checklistGoal.CompletionCount < checklistGoal.TargetCount - 1)
            {
                checklistGoal.CompletionCount += 1;
                score += checklistGoal.PointsPerCompletion;
            }
            else
            {
                checklistGoal.CompletionCount += 1;
                score += checklistGoal.PointsPerCompletion;
                checklistGoal.IsCompleted = true;
                score += checklistGoal.BonusPoint;
            }
        }
        else if (goal is EternalGoal eternalGoal)
        {
            eternalGoal.IsCompleted = false;
            score += eternalGoal.GetPoints();
        }
        else
        {
            goal.IsCompleted = true;
            score += goal.GetPoints();
        }

        Console.WriteLine("Congratulations!");
    }

    private static void ListGoals()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < goals.Count; i++)
        {
            Goal goal = goals[i];
            Console.WriteLine($"{i + 1}. {goal.GetProgress()}");
        }
    }

    private static void SaveData()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine(score);
            foreach (Goal goal in goals)
            {
                if (goal is SimpleGoal simpleGoal)
                {
                    writer.WriteLine($"{goal.GetType().Name},{goal.Name},{goal.Description},{goal.GetPoints()},{goal.IsCompleted}");
                }
                if (goal is EternalGoal eternalGoal)
                {
                    writer.WriteLine($"{goal.GetType().Name},{goal.Name},{goal.Description},{goal.GetPoints()},{goal.IsCompleted}");
                }
                if (goal is ChecklistGoal checklistGoal)
                {
                    writer.WriteLine($"{goal.GetType().Name},{goal.Name},{goal.Description},{goal.GetPoints()},{goal.IsCompleted},{checklistGoal.BonusPoint},{checklistGoal.TargetCount},{checklistGoal.CompletionCount}");
                }
            }
        }
    }

    private static void LoadData()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        if (File.Exists(fileName))
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                int scoreText = int.Parse(reader.ReadLine());
                score = scoreText;
                while (!reader.EndOfStream)
                {
                    string[] goalData = reader.ReadLine().Split(',');

                    if (goalData.Length < 4)
                        continue;

                    string goalType = goalData[0];
                    string name = goalData[1];
                    string description = goalData[2];
                    int points = int.Parse(goalData[3]);
                    bool isCompleted = bool.Parse(goalData[4]);

                    Goal goal;

                    switch (goalType)
                    {
                        case "SimpleGoal":
                            goal = new SimpleGoal { Name = name, Description = description, Points = points, IsCompleted = isCompleted };
                            break;
                        case "EternalGoal":
                            goal = new EternalGoal { Name = name, Description = description, PointsPerCompletion = points, IsCompleted = isCompleted };
                            break;
                        case "ChecklistGoal":
                            goal = new ChecklistGoal { Description = description, PointsPerCompletion = 0, TargetCount = 0 };
                            if (goalData.Length >= 5)
                            {
                                int bonusPoint = int.Parse(goalData[5]);
                                int targetCount = int.Parse(goalData[6]);
                                int completionCount = int.Parse(goalData[7]);
                                ((ChecklistGoal)goal).BonusPoint = bonusPoint;
                                ((ChecklistGoal)goal).CompletionCount = completionCount;
                                ((ChecklistGoal)goal).TargetCount = targetCount;
                            }
                            break;
                        default:
                            continue;
                    }

                    goal.IsCompleted = isCompleted;
                    goals.Add(goal);
                }
            }
        }
    }
}