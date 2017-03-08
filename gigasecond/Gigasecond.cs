using System;

public static class Gigasecond
{
    public static DateTime Date(DateTime birthDate)
    {
        // throw new NotImplementedException("You need to implement this function.");
        return birthDate.AddSeconds(1000000000);
    }
}