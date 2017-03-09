using System;

public static class Raindrops
{
    public static string Convert(int number)
    {
        
        String result = "";

        for (int i = 1; i <= number; i++)
        {
            bool test = (number % i == 0);

            if(test == true){
                if (i == 3)
                    result += "Pling";
                else if(i == 5)
                    result += "Plang";
                else if(i == 7)
                    result += "Plong";
            }
        }

        if(result.Equals(""))
            return number.ToString();

        return result;
    }
}