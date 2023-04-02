using System;

// Clase para bicicleta estacionaria
public class Bike : Activity 
{
    private double speed;

    public Bike(DateTime date, int duration, double speed) 
        : base(date, duration) 
    {
        this.speed = speed;
    }

    public override double GetSpeed() 
    {
        return speed;
    }

    public override double GetDistance() 
    {
        return (speed * (duration / 60.0));
    }

    public override double GetRhythm() 
    {
        return (1.0 / speed) * 60.0;
    }

    public override string GetSummary() 
    {
        return string.Format("{0} Bike ({1} min) - Distance {2:F1} km, Speed {3:F1} kph, Rhythm: {4:F1} min per km", 
            date.ToShortDateString(), duration, GetDistance(), GetSpeed(), GetRhythm());
    }
}