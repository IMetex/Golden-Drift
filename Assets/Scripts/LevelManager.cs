using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene("SelectMenu");
    }
    public void GameQuit()
    {
        Application.Quit();
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("StartPage");
    }
}
