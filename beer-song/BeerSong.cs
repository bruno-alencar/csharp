using System;

public static class Beer
{


    static string[] phrases = {
            "10 bottles of beer on the wall, 10 bottles of beer.\n"+
            "Take one down and pass it around, 9 bottles of beer on the wall.\n",

            "9 bottles of beer on the wall, 9 bottles of beer.\n"+
            "Take one down and pass it around, 8 bottles of beer on the wall.\n",

            "8 bottles of beer on the wall, 8 bottles of beer.\n"+
            "Take one down and pass it around, 7 bottles of beer on the wall.\n",

            "7 bottles of beer on the wall, 7 bottles of beer.\n"+
            "Take one down and pass it around, 6 bottles of beer on the wall.\n",

            "6 bottles of beer on the wall, 6 bottles of beer.\n"+
            "Take one down and pass it around, 5 bottles of beer on the wall.\n",

            "5 bottles of beer on the wall, 5 bottles of beer.\n"+
            "Take one down and pass it around, 4 bottles of beer on the wall.\n",

            "4 bottles of beer on the wall, 4 bottles of beer.\n"+
            "Take one down and pass it around, 3 bottles of beer on the wall.\n",

            "3 bottles of beer on the wall, 3 bottles of beer.\n"+
            "Take one down and pass it around, 2 bottles of beer on the wall.\n",

            "2 bottles of beer on the wall, 2 bottles of beer.\n"+
            "Take one down and pass it around, 1 bottle of beer on the wall.\n",

            "1 bottle of beer on the wall, 1 bottle of beer.\n"+
            "Take it down and pass it around, no more bottles of beer on the wall.\n",
            "No more bottles of beer on the wall, no more bottles of beer.\n"+
"Go to the store and buy some more, 99 bottles of beer on the wall.\n"
        };
    public static string Verse(int number)
    {
        // throw new NotImplementedException("You need to implement this function.");
        foreach (var phrase in phrases)
        {
            if (phrase.StartsWith(number.ToString()+" "))
                return phrase;
        }


        return phrases[phrases.Length - 1];

    }

    public static string Sing(int start, int stop)
    {
        // throw new NotImplementedException("You need to implement this function.");
        string result = "";

        for(int i = start; i >= stop; i--)
        {
            result += Verse(i) + "\n" ;
        }

        return result;
    }
}