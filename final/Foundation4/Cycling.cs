class Cycling : Activity
{
    public double Speed { get; set; }

    public override double GetDistance()
    {
        return Speed * (LengthInMinutes / 60);
    }

    public override double GetSpeed()
    {
        return Speed;
    }

    public override double GetPace()
    {
        return 60 / Speed;
    }
}