using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void nextScene()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void pause()
    {
        Time.timeScale = 0;
    }

    public void exit()
    {
        Application.Quit();
    }
}