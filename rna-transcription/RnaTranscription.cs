using System;

public static class Complement
{
    public static string OfDna(string nucleotide)
    {
        // throw new NotImplementedException("You need to implement this function.");

        String changed = "";
        for (int i = 0; i < nucleotide.Length; i++)
        {
            if (nucleotide[i] == 'G')
            {
                changed += "C";
            }
            else if (nucleotide[i] == 'C')
            {
                changed += "G";
            }
            else if (nucleotide[i] == 'T')
            {
                changed += "A";
            }
            else
            {
                changed += "U";
            }
        }

        return changed;
    }
}