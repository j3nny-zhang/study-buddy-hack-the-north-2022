using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SetTime : MonoBehaviour
{

    TextMeshProUGUI timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        timer.SetText(Timer.timerMinutes.ToString() + ":00");
    }
}
