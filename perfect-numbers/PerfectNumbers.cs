using System;

public enum NumberType
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static NumberType Classify(int number)
    {
        // throw new NotImplementedException();
        int sum = 0;

        for (int i = 1; i < number; i++)
        {
            if(number % i == 0)
                sum += i;
        }

        if(sum == number)
            return NumberType.Perfect;
        else if(sum > number)
            return NumberType.Abundant;
        else
            return NumberType.Deficient;

    }
}
