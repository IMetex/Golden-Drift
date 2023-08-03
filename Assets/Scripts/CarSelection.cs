using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CarSelection : MonoBehaviour
{
    [SerializeField] private GameObject[] cars;

    [SerializeField] private Button next;

    [SerializeField] private Button prev;

    int index;

    private void Start()
    {
        index = PlayerPrefs.GetInt("carIndex");

        for (int i = 0; i < cars.Length; i++)
        {
            cars[i].SetActive(false);
            cars[index].SetActive(true);
        }

    }

    private void Update()
    {
        if (index >= 2)
            next.interactable = false;
        else
            next.interactable = true;

        if (index <= 0)
            prev.interactable = false;
        else
            prev.interactable = true;
    }

    public void Next()
    {
        index++;

        for (int i = 0; i < cars.Length; i++)
        {
            cars[i].SetActive(false);
            cars[index].SetActive(true);
        }

        PlayerPrefs.SetInt("carIndex", index);
        PlayerPrefs.Save();
    }

    public void Prev()
    {
        index--;

        for (int i = 0; i < cars.Length; i++)
        {
            cars[i].SetActive(false);
            cars[index].SetActive(true);
        }

        PlayerPrefs.SetInt("carIndex", index);
        PlayerPrefs.Save();
    }

    public void Race()
    {
        SceneManager.LoadScene("Level 1");
    }
}
