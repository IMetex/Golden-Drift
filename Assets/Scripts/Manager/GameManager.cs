using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject[] cars;
    private GameObject _instantiatedCar;
    private int index;

    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if (!_instance)
            {
                _instance = FindObjectOfType<GameManager>();
            }

            return _instance;
        }
    }

    private void Start()
    {
        index = PlayerPrefs.GetInt("carIndex");
        _instantiatedCar = Instantiate(cars[index], Vector3.zero, Quaternion.identity);
        FindObjectOfType<CamController>().target = _instantiatedCar.transform;

    }
}
