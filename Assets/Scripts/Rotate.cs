using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private Vector3 _offset;

    private void FixedUpdate()
    {
        transform.Rotate(_offset);
    }
}
