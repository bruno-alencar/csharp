using System;

public static class Year
{
    public static bool IsLeap(int year)
    {
        // throw new NotImplementedException("You need to implement this function.");

      bool validator = false; 
        if (year % 4 == 0)
        {
            validator = true;
            if (year % 100 == 0)
            {
                validator = false;
                if (year % 400 == 0)
                    validator = true;
            }
        }

        return validator;
    }
}