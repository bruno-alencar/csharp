using System;
using System.Linq;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        // throw new NotImplementedException();

        // return input.ToLower().Where(c => Char.IsLetter(c)).GroupBy(c => c).Count() == 26;
        bool validador = true;
        const string StrComAcentos = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç";
        const string StrSemAcentos = "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCc";



        input = input.Trim().ToLower();

        if (input.Length > 0)
        {
            for (int i = 0; i < StrComAcentos.Length; i++)
            {
                input = input.Replace(StrComAcentos[i], StrSemAcentos[i]);
            }


            for (char c = 'a'; c <= 'z'; c++)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (!Char.IsLetter(input[i]) || input[i] != c)
                        validador = false;
                    else{
                        validador = true;
                        break;
                    }
                }

                if(validador == false)
                    return false;
            }
        }
        else
        {
            return false;
        }

        return validador;
    }
}
