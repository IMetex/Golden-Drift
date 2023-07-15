using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    [SerializeField] private Transform target;

    [SerializeField] private float smoothSpeed = 0.125f;

    [SerializeField] private Vector3 offset;

    private void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smootPosition = Vector3.Lerp(target.position, desiredPosition,smoothSpeed);
        transform.position = smootPosition;

        transform.LookAt(target);

    }


}
