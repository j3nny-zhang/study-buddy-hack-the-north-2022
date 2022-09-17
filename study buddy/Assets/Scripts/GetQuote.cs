using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetQuote : MonoBehaviour
{

    public TextMeshProUGUI quoteText;

    void Start()
    {
        quoteText = GetComponent<TextMeshProUGUI>();
        NewQuote();
    }

    public void NewQuote()
    {
        Quote q = APIHelper.GetNewQuote();
        quoteText.SetText("\"" + q.quote + "\"\n\n - " + q.person);
    }

}
