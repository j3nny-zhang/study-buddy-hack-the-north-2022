using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public static float timerCount = 5;
    TextMeshProUGUI timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = GetComponent<TextMeshProUGUI>();
        timer.SetText(timerCount.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        if (timerCount <= 0)
        {
            timer.SetText("0");
        } else
        {
            timerCount -= Time.deltaTime;
            int timerInt = (int)timerCount;
            timer.SetText(timerInt.ToString());
        }
    }
}
