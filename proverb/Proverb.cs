using System;
using System.Collections.Generic;

public static class Proverb
{
    public static string Line(int line)
    {
        // throw new NotImplementedException();

        List<string> allFullPhrase = new List<string>();

        allFullPhrase.Add("For want of a nail the shoe was lost.");
        allFullPhrase.Add("For want of a shoe the horse was lost.");
        allFullPhrase.Add("For want of a horse the rider was lost.");
        allFullPhrase.Add("For want of a rider the message was lost.");
        allFullPhrase.Add("For want of a message the battle was lost.");
        allFullPhrase.Add("For want of a battle the kingdom was lost.");
        allFullPhrase.Add("And all for the want of a horseshoe nail.");

        return allFullPhrase[line-1];
    }

    public static string AllLines()
    {
          List<string> allFullPhrase = new List<string>();

        allFullPhrase.Add("For want of a nail the shoe was lost.");
        allFullPhrase.Add("For want of a shoe the horse was lost.");
        allFullPhrase.Add("For want of a horse the rider was lost.");
        allFullPhrase.Add("For want of a rider the message was lost.");
        allFullPhrase.Add("For want of a message the battle was lost.");
        allFullPhrase.Add("For want of a battle the kingdom was lost.");
        allFullPhrase.Add("And all for the want of a horseshoe nail.");

        string results = "";
        foreach(string phrase in allFullPhrase)
            results += phrase +"\n";
        
        results = results.Substring(0, results.Length-1);

        return results;
    }
}