using System;

public class Clock
{
    private readonly TimeSpan _timeSpanOneDay = TimeSpan.FromTicks(TimeSpan.TicksPerDay);
    private TimeSpan _time;

    public Clock(int hours)
    {
        _time = new TimeSpan(hours, 0, 0);
    }

    public Clock(int hours, int minutes)
    {
        _time = new TimeSpan(hours, minutes, 0);
    }

    public Clock Add(int minutesToAdd)
    {
        _time = _time.Add(TimeSpan.FromMinutes(minutesToAdd));
        return this;
    }

    public Clock Subtract(int minutesToSubtract)
    {
        _time = _time.Subtract(TimeSpan.FromMinutes(minutesToSubtract))
                     .Add(_timeSpanOneDay);
        return this;
    }

    public override string ToString()
    {
        return _time.ToString(@"hh\:mm");
    }

    public override int GetHashCode()
    {
        return _time.GetHashCode();
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        var oTime = ((Clock)obj)._time;
        return _time.Hours.Equals(oTime.Hours) && 
                _time.Minutes.Equals(oTime.Minutes);
    }

    // overload operator ==
    public static bool operator ==(Clock a, Clock b)
    {
        return a._time == b._time;
    }

    // overload operator !=
    public static bool operator !=(Clock a, Clock b)
    {
        return a._time != b._time;
    }
}