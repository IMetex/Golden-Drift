using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{
    [SerializeField] private Button[] buttons;

    [SerializeField] private GameObject[] deactiveUI;

    [SerializeField] private GameObject levelMenuPage;
    private void Awake()
    {
        int unlockedLevel = PlayerPrefs.GetInt("UnlockedLevel", 1);

        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }

        for (int i = 0; i < unlockedLevel; i++)
        {
            buttons[i].interactable = true;
        }

        levelMenuPage.SetActive(false);
    }

    public void OpenLevel(int levelId)
    {
        string levelName = "Level" + levelId;
        SceneManager.LoadScene(levelName);
    }

    public void OpenLevelPage()
    {
        for (int i = 0; i < deactiveUI.Length; i++)
        {
            deactiveUI[i].SetActive(false);
        }
        levelMenuPage.SetActive(true);

    }
}
