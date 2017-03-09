using System;

public class BankAccount
{

    private float value;
    private bool openned;
    public void Open()
    {
        // throw new NotImplementedException("You need to implement this function.");
        value = 0;
        openned = true;
    }

    public void Close()
    {
        // throw new NotImplementedException("You need to implement this function.");
        openned = false;
    }

    public float Balance
    {
        get
        {
            // throw new NotImplementedException("You need to implement this property.");
            
            if(openned == true)
                return value;
            else
                throw new InvalidOperationException();
        }
    }

    public void UpdateBalance(float change)
    {
        lock(this)
        value += change;
        // Console.WriteLine(value);
    }
}
