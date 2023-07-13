public class EternalGoal : Goal
{
    private int pointsPerCompletion;

    public int PointsPerCompletion
    {
        get { return pointsPerCompletion; }
        set { pointsPerCompletion = value; }
    }

    public override int GetPoints()
    {
        return PointsPerCompletion;
    }

    public override string GetProgress()
    {
        return $"[ ] {this.Name} ({this.Description})";
    }
}