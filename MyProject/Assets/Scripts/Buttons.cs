using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public GameObject pause;
    public GameObject panel;
    public void StartButton()
    {
        SceneManager.LoadScene(1);
    }   
    public void RestartGame()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1;
    }
    public void QuitButton()
    {
        Application.Quit();
    } 

    public void PauseButton()
    {
        pause.SetActive(true);
        Time.timeScale = 0;
    }

    public void contiuneButton()
    {
        pause.SetActive(false);
        Time.timeScale = 1;
    }

    public void anaMenu()
    {
        panel.SetActive(false);
    }

    public void howtoplay()
    {
        panel.SetActive(true);
    }

    public void mainMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

}
