using System;

// Clase para nadar
public class Swimming : Activity 
{
    private int laps;

    public Swimming(DateTime date, int duration, int laps) 
        : base(date, duration) 
    {
        this.laps = laps;
    }

    public override double GetDistance() 
    {
        return laps * 50.0 / 1000.0;
    }

    public override double GetSpeed() 
    {
        return GetDistance() / (duration / 60.0);
    }

    public override double GetRhythm() 
    {
        return (duration / 60.0) / (laps * 50.0 / 1000.0);
    }

    public override string GetSummary() 
    {
        return string.Format("{0} Swimming ({1} min) - Distance {2:F1} km, Speed {3:F1} kph, Rhythm: {4:F1} min per km", 
            date.ToShortDateString(), duration, GetDistance(), GetSpeed(), GetRhythm());
    }

}