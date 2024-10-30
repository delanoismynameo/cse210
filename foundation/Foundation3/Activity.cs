using System;

public abstract class Activity
{
    private string date;
    private int minutes;

    public Activity(string date, int minutes)
    {
        this.date = date;
        this.minutes = minutes;
    }

    public int Minutes => minutes;
    public string Date => date;

    // Abstract methods for distance, speed, and pace calculations, to be implemented by subclasses.
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Summary method that all derived classes can use.
    public virtual string GetSummary()
    {
        return $"{Date} - {GetType().Name} ({Minutes} min): Distance {GetDistance():0.0} km, Speed {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
    }
}
