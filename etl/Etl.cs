using System;
using System.Collections.Generic;

public static class ETL
{
    public static IDictionary<string, int> Transform(IDictionary<int, IList<string>> old)
    {
        // throw new NotImplementedException("You need to implement this function.");\

        Dictionary<string, int> edited = new Dictionary<string, int>();

        
        foreach (KeyValuePair<int,IList<String>> valor in old)
        {
            foreach (string teste in valor.Value)
            {
                edited.Add(teste.ToLower(), valor.Key);
            }
        }
        
        return edited;
    }
}