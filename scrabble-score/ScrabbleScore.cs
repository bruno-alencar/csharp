using System;

public static class Scrabble
{
    public static int Score(string input)
    {
        // throw new NotImplementedException("You need to implement this function.")
        int total = 0;

        if(input == null || input.Trim().Equals("")  )
            return 0;

        input = input.ToLower();

        foreach (char letter in input)
        {

            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' ||
            letter == 'u' || letter == 'l' || letter == 'n' || letter == 'r' || letter == 's' ||
            letter == 't')
                total += 1;
            else if (letter == 'd' || letter == 'g')
                total += 2;
            else if(letter == 'b' || letter == 'c' || letter == 'm' || letter == 'p')
                total += 3;
            else if(letter == 'f' || letter == 'h' || letter == 'v' || letter == 'w' ||
            letter == 'y')
                total += 4;
            else if (letter == 'k')
                total += 5;
            else if (letter == 'j' || letter == 'x')
                total += 8;
            else
                total += 10;               
        }

        return total;
    }
}