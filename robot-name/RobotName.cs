using System;
using System.Text;

public class Robot
{
    
    private static Random random = new Random();

    public Robot(){
        Reset();
    }
    public string Name
    {
        get;
            // throw new NotImplementedException("You need to implement this function."
        private set;
    }

    public void Reset()
    {
        // throw new NotImplementedException("You need to implement this function.");
            string allWords = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string allNumbers = "1234567890";
            StringBuilder stringBuilder = new StringBuilder(100);

            stringBuilder.Append(allWords[random.Next(allWords.Length)]);
            stringBuilder.Append(allWords[random.Next(allWords.Length)]);
            stringBuilder.Append(allNumbers[random.Next(allNumbers.Length)]);
            stringBuilder.Append(allNumbers[random.Next(allNumbers.Length)]);
            stringBuilder.Append(allNumbers[random.Next(allNumbers.Length)]);

            Name =  stringBuilder.ToString();
    }
}