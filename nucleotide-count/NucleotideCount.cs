using System;
using System.Collections.Generic;

public class DNA
{

    private string sequence;
    public DNA(string sequence)
    {
        this.sequence = sequence;
    }

    public IDictionary<char, int> NucleotideCounts
    {
        get
        {
            // throw new NotImplementedException("You need to implement this function.");
            Dictionary<char, int> nucleotides = new Dictionary<char, int>();

            nucleotides.Add('A', this.Count('A'));
            nucleotides.Add('T', this.Count('T'));
            nucleotides.Add('C', this.Count('C'));
            nucleotides.Add('G', this.Count('G'));

            return nucleotides;
        }
    }

    public int Count(char nucleotide)
    {
        // throw new NotImplementedException("You need to implement this function.");
        int count = 0;

        for(int i = 0; i < sequence.Length; i++)
        {
            if(sequence[i] == nucleotide)
                count++;
        }

        if(count == 0)
        {
            if(nucleotide != 'A' && nucleotide != 'T' &&
             nucleotide != 'C' && nucleotide != 'G')
                throw new InvalidNucleotideException();
        }

        return count;
    }
}

public class InvalidNucleotideException : Exception { }
