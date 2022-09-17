using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    private static float timerSeconds = 0;
    public static float timerMinutes = 5;

    TextMeshProUGUI timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {

        timerSeconds -= Time.deltaTime;
        int timerIntSeconds = (int)timerSeconds;
        int timerIntMinutes = (int)timerMinutes;

        if (timerMinutes < 0)
        {
            timer.SetText("0:00");

            // switch scenes
            timerMinutes = 5;
            SceneManager.LoadScene("Start");
        }
        else if (timerSeconds <= 0)
        {
            timerMinutes -= 1;
            timerSeconds = 60;
        } 
        else if (timerSeconds <= 10)
        {
            timer.SetText(timerIntMinutes.ToString() + ":0" + timerIntSeconds.ToString());
        }
        else
        {
            timer.SetText(timerIntMinutes.ToString() + ":" + timerIntSeconds.ToString());
        }
    }

}
