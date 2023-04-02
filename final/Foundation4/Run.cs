using System;

public class Run : Activity 
{
    private double distance;

    public Run(DateTime date, int duration, double distance) 
        : base(date, duration) 
    {
        this.distance = distance;
    }

    public override double GetDistance() 
    {
        return distance;
    }

    public override double GetSpeed() 
    {
        return distance / (duration / 60.0);
    }

    public override double GetRhythm() 
    {
        return (duration / 60.0) / distance;
    }

    public override string GetSummary() 
    {
        return string.Format("{0} Race ({1} min) - Distance {2:F1} km, Speed {3:F1} kph, Rhythm: {4:F1} min per km", 
            date.ToShortDateString(), duration, distance, GetSpeed(), GetRhythm());
    }
}