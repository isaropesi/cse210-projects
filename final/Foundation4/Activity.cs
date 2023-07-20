using System;
using System.Collections.Generic;

class Activity
{
    public DateTime Date { get; set; }
    public int LengthInMinutes { get; set; }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        string summary = Date.ToShortDateString() + " ";

        if (this is Running)
        {
            Running running = (Running)this;
            summary += "Running (" + LengthInMinutes + " min) - ";
            summary += "Distance: " + running.GetDistance() + " miles, ";
            summary += "Speed: " + running.GetSpeed() + " mph, ";
            summary += "Pace: " + running.GetPace() + " min/mile";
        }
        else if (this is Cycling)
        {
            Cycling cycling = (Cycling)this;
            summary += "Cycling (" + LengthInMinutes + " min) - ";
            summary += "Distance: " + cycling.GetDistance() + " km, ";
            summary += "Speed: " + cycling.GetSpeed() + " kph, ";
            summary += "Pace: " + cycling.GetPace() + " min/km";
        }
        else if (this is Swimming)
        {
            Swimming swimming = (Swimming)this;
            summary += "Swimming (" + LengthInMinutes + " min) - ";
            summary += "Distance: " + swimming.GetDistance() + " laps, ";
            summary += "Speed: " + swimming.GetSpeed() + " mph, ";
            summary += "Pace: " + swimming.GetPace() + " min/lap";
        }

        return summary;
    }
}