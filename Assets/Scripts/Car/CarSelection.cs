using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CarSelection : MonoBehaviour
{
    [SerializeField] private GameObject[] cars;

    [SerializeField] private GameObject[] descriptions;

    [SerializeField] private Button next;

    [SerializeField] private Button prev;

    int index;
    int indexDescription;

    private void Start()
    {
        index = PlayerPrefs.GetInt("carIndex");
        indexDescription = PlayerPrefs.GetInt("descriptionIndex");

        for (int i = 0; i < cars.Length && i < descriptions.Length; i++)
        {
            cars[i].SetActive(false);
            cars[index].SetActive(true);

            descriptions[i].SetActive(false);
            descriptions[indexDescription].SetActive(true);
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
        indexDescription++;

        if (index >= cars.Length)
            index = 0;

        if (indexDescription >= descriptions.Length)
            indexDescription = 0;

        for (int i = 0; i < cars.Length; i++)
        {
            cars[i].SetActive(i == index);
        }

        for (int i = 0; i < descriptions.Length; i++)
        {
            descriptions[i].SetActive(i == indexDescription);
        }

        PlayerPrefs.SetInt("carIndex", index);
        PlayerPrefs.SetInt("descriptionIndex", indexDescription);
        PlayerPrefs.Save();
    }

    public void Prev()
    {
        index--;
        indexDescription--;

        if (index < 0)
            index = cars.Length - 1;

        if (indexDescription < 0)
            indexDescription = descriptions.Length - 1;

        for (int i = 0; i < cars.Length; i++)
        {
            cars[i].SetActive(i == index);
        }

        for (int i = 0; i < descriptions.Length; i++)
        {
            descriptions[i].SetActive(i == indexDescription);
        }

        PlayerPrefs.SetInt("carIndex", index);
        PlayerPrefs.SetInt("descriptionIndex", indexDescription);
        PlayerPrefs.Save();
    }

    public void Race()
    {
        SceneManager.LoadScene("Level 1");
    }
}
