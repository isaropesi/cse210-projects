public class ChecklistGoal : Goal
{
    private int pointsPerCompletion;
    private int targetCount;
    private int completionCount;
    private int bonusPoint;

    public int PointsPerCompletion
    {
        get { return pointsPerCompletion; }
        set { pointsPerCompletion = value; }
    }

    public int TargetCount
    {
        get { return targetCount; }
        set { targetCount = value; }
    }

    public int CompletionCount
    {
        get { return completionCount; }
        set { completionCount = value; }
    }

    public int BonusPoint
    {
        get { return bonusPoint; }
        set { bonusPoint = value; }
    }

    public override int GetPoints()
    {
        if (IsCompleted && CompletionCount >= TargetCount)
            return PointsPerCompletion + BonusPoint;
        return PointsPerCompletion;
    }

    public override string GetProgress()
    {
        string progress = IsCompleted ? "[X]" : "[ ]";
        return $"{progress} {this.Name} ({this.Description}) -- Currently completed {CompletionCount}/{TargetCount}";
    }

}