using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartTimer(string sceneName)
    {
        Debug.Log("clicked");
        SceneManager.LoadScene(sceneName);
    }
}
