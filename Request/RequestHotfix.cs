using System;
using System.IO;
using System.Net;

class RequestHotfix
{

    static void Main(string[] args)
    {
        RequestHotfix teste = new RequestHotfix();
        teste.Start();
    }

    public void Start()
    {
        string url = @"http\://nfe-prod-backend-api.azurewebsites.net/accounts/";

        string result = this.Connect(url);
        Console.Write(result);

    }


    public string Connect(string url)
    {
        WebClient client = new WebClient();

        client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
        client.Headers.Add("Authorization", "Bearer q1GpNhG2ihcvoI1-aSN04_rz_OvQ5kWoRoqieF1PB3-z4mdZspSmAk0j41WMF2gYodwMvCJ4xP9AVCIzxmQ8K3qzAEju0pketlYwhjVFAF9OW7ZMKQG9KiHtrTpKX4-YfDn3A999KxWsYEiQCMnwXNuckUjntbpZXYIRNGKFEtdCGet6xZNuKoROjmQWEDO2sGdmy-2wYH1-kxvTC4JCwT9QW_OiouxRE9J17i1Hn6I2OONr0Xbd48acrJbJgBSpC2_AIIDJHxtsODPQyq1ghEhfgmkUQElzAtbox5Yw66RdMmln6gJg-XJd-XB6x23QKT2WdQBm9AahwH2_ojJTxs1mtTOJ3LWAPobWSsjFZFcP22MNt6iRLO2tSvUtmNH8kkWxouEhrGjmMJyjQHZr-opamx5rvyU5niT72zBU7FTO6lMd9zYKUo16zHTANmSugrZGKXr9K2auLYCkwiz3azSCchDIlE84LdIyQhjDb6t4HEwKf_dwwCEUT0tleNg4rBwdPMKtS3pn__NWhgasXQ");


        Stream data = client.OpenRead(url);
        StreamReader reader = new StreamReader(data);

        String json = reader.ReadToEnd();

        data.Close();
        reader.Close();

        return json;

    }
}
