using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    //Finish Game
    public void Restart_btn()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

    public void Exit_btn()
    {
        Application.Quit();
    }
}
