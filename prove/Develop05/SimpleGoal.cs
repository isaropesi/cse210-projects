public class SimpleGoal : Goal
{
    private int points;

    public int Points
    {
        get { return points; }
        set { points = value; }
    }

    public override int GetPoints()
    {
        return Points;
    }

    public override string GetProgress()
    {
        string progress = IsCompleted ? "[X]" : "[ ]";
        return $"{progress} {this.Name} ({this.Description})";
    }
}