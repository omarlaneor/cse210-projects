using System;

public class Activity 
{
    protected DateTime date;
    protected int duration;

    public Activity(DateTime date, int duration) 
    {
        this.date = date;
        this.duration = duration;
    }

    public virtual double GetDistance() 
    {
        return 0;
    }

    public virtual double GetSpeed() 
    {
        return 0;
    }

    public virtual double GetRhythm() 
    {
        return 0;
    }

    public virtual string GetSummary() 
    {
        return string.Format("{0} - {1} min", date.ToShortDateString(), duration);
    }
}
