using System;
using System.Collections.Generic;

public static class SumOfMultiples
{
    public static int To(IEnumerable<int> multiples, int max)
    {
        // throw new NotImplementedException("You need to implement this function.");

        int value = 0;

        List<int> temp = new List<int>();

        foreach (int multiple in multiples)
        {
            for (int i = 0; i < max; i++)
            {
                if (i % multiple == 0 && !temp.Contains(i))
                    temp.Add(i);
            }
        }

        foreach(int val in temp)
        {
            value += val;
        }

        return value;
    }
}