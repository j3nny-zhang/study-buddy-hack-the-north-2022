using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void StartTimer(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void addTime()
    {
        Timer.timerMinutes += 5;
    }

    public void subtractTime()
    {
        Timer.timerMinutes -= 5;
    }
}
