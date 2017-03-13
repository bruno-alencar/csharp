using System;
using System.Collections.Generic;

public static class ProteinTranslation
{
    public static string[] Translate(string codon)
    {
        // throw new NotImplementedException();
        Dictionary<IEnumerable<string>, string> allData = new Dictionary<IEnumerable<string>, string>();

        allData.Add(new[] { "AUG" }, "Methionine");
        allData.Add(new[] { "UUU", "UUC" }, "Phenylalanine");
        allData.Add(new[] { "UUA", "UUG" }, "Leucine");
        allData.Add(new[] { "UCU", "UCC", "UCA", "UCG" }, "Serine");
        allData.Add(new[] { "UAU", "UAC" }, "Tyrosine");
        allData.Add(new[] { "UGU", "UGC" }, "Cysteine");
        allData.Add(new[] { "UGG" }, "Tryptophan");
        allData.Add(new[] { "UAA", "UAG", "UGA" }, "STOP");

        List<string> result = new List<string>();
        bool validate = false;

        for (int i = 0; i < codon.Length; i += 3)
        {
            foreach (var data in allData)
            {
                foreach (string keyForCodon in data.Key)
                {
                    string valor = codon.Substring(i, 3);
                    if (keyForCodon.Equals(valor))
                    {
                        Console.Write(valor+"\n");
                        if (data.Value == "STOP"){
                            validate = true;
                            break;
                        }
                        result.Add(data.Value);
                    }
                }
                if(validate == true)
                    break;
            }

            if(result.Count == 0)
                throw new Exception();
        }


        return result.ToArray();
    }
}