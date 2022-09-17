using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetQuote : MonoBehaviour
{

    public TextMeshProUGUI quoteText;
    public float timerChange = 0.0f;

    void Start()
    {
        quoteText = GetComponent<TextMeshProUGUI>();
        NewQuote();
    }

    void Update()
    {
        timerChange += Time.deltaTime;

        if (timerChange >= 300.0f)
        {
            NewQuote();
            timerChange = 0;
        }

    }

    public void NewQuote()
    {
        Quote q = APIHelper.GetNewQuote();
        quoteText.SetText("\"" + q.quote + "\"\n\n - " + q.person);
    }

}
