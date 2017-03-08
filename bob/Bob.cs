using System;

public class Bob
{
    public static string Hey(string statement)
    {
        // throw new NotImplementedException("You need to implement this function.");
    
        if(statement.Trim().Equals(""))
        {
            return "Fine. Be that way!";
        }
        else if (isAllUpper(statement))
        {
            return "Whoa, chill out!";
        }
        else if (statement.Trim().EndsWith("?"))
        {
            return "Sure.";
        }
        else
        {
            return "Whatever.";
        }

    }

    private static bool isAllUpper(String statement)
    {
        bool onlyNumber = true;
        for (int i = 0; i < statement.Length; i++)
        {
            if (Char.IsLetter(statement[i]) && !Char.IsUpper(statement[i]))
                return false;

            if(Char.IsLetter(statement[i]))
                onlyNumber = false;
        }

        if(onlyNumber == true){
            return false;
        }
        return true;
    }
}