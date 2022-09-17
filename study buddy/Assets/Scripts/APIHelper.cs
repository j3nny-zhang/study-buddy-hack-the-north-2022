using UnityEngine;
using System.Net;
using System.IO;

public static class APIHelper
{
    public static Quote GetNewQuote()
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://motivational-quote-api.herokuapp.com/quotes/random");
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());

        string json = reader.ReadToEnd();
        return JsonUtility.FromJson<Quote>(json);
    }
}
