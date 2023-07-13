public abstract class Goal
{
    private string name;
    private string description;
    //private int score;
    private bool isCompleted;

    public string Name 
    {
        get { return name; }
        set { name = value; }
    }

    public string Description
    {
        get { return description; }
        set { description = value; }
    }

    // public int Score 
    // {
    //     get { return score; }
    //     set { score = value; }
    // }

    public bool IsCompleted
    {
        get { return isCompleted; }
        set { isCompleted = value; }
    }

    public abstract int GetPoints();
    public abstract string GetProgress();
}