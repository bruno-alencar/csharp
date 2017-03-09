using System;

public class SpaceAge
{

    private long seconds;
    private double age;
    public SpaceAge(long seconds)
    {
        this.seconds = seconds;
        this.age = 31557600;
    }

    public double OnEarth()
    {
        // throw new NotImplementedException("You need to implement this function.")
        return Math.Round(this.seconds / age, 2);
    }

    public double OnMercury()
    {
        // throw new NotImplementedException("You need to implement this function.");
        return Math.Round(this.seconds / (age*0.2408467),2);
    }

    public double OnVenus()
    {
        // throw new NotImplementedException("You need to implement this function.");
        return Math.Round(this.seconds / (age*0.61519726),2);
    }

    public double OnMars()
    {
        // throw new NotImplementedException("You need to implement this function.");
        return Math.Round(this.seconds / (age*1.8808158),2);
    }

    public double OnJupiter()
    {
        // throw new NotImplementedException("You need to implement this function.");
        return Math.Round(this.seconds / (age*11.862615),2);
    }

    public double OnSaturn()
    {
        // throw new NotImplementedException("You need to implement this function.");
        return Math.Round(this.seconds / (age*29.447498),2);
    }

    public double OnUranus()
    {
        // throw new NotImplementedException("You need to implement this function.");
        return Math.Round(this.seconds / (age*84.016846),2);
    }

    public double OnNeptune()
    {
        // throw new NotImplementedException("You need to implement this function.");
        return Math.Round(this.seconds / (age*164.79132),2);
    }
}