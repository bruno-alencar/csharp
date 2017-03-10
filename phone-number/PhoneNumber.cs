using System;
using System.Text.RegularExpressions;

public class PhoneNumber
{

    private string phoneNumber;
    public PhoneNumber(string phoneNumber)
    {
        this.phoneNumber = phoneNumber;
    }

    public string Number
    {
        get
        {
            // throw new NotImplementedException("You need to implement this function.");
            this.phoneNumber = Regex.Replace(this.phoneNumber, "[^0-9]+", "");

            if(this.phoneNumber.Length == 10  || this.phoneNumber.Length == 11)
            {
                if(this.phoneNumber.Length == 11 && this.phoneNumber.StartsWith("1"))
                    this.phoneNumber = this.phoneNumber.Substring(1,this.phoneNumber.Length-1);
                else if(this.phoneNumber.Length == 11)
                    return "0000000000";

                return this.phoneNumber;
            }
            else
                return "0000000000";
        }
    }

    public override string ToString(){
        this.phoneNumber = Regex.Replace(this.phoneNumber, @"(\d{3})(\d{3})(\d{4})", "($1) $2-$3");
        return this.phoneNumber;
    }

    public string AreaCode
    {
        get
        {
            // throw new NotImplementedException("You need to implement this function.");
            return this.phoneNumber.Substring(0,3);
        }
    }
}