using System;

public static class Hamming
{
    public static int Compute(string firstStrand, string secondStrand)
    {
        int count = 0;
        for(int i = 0; i < firstStrand.Length; i++)
        {
                if(firstStrand[i] != secondStrand[i])
                    count ++;
        }

        return count;
    }
}