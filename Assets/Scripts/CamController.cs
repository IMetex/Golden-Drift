using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    public Transform target;

    [SerializeField] private float smoothSpeed = 0.125f;

    [SerializeField] private Vector3 offset;


    private void FixedUpdate()
    {
        if (target == null)
        {
            return; // If the target is not set, do nothing
        }

        Vector3 desiredPosition = target.position + offset;
        Vector3 smootPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smootPosition;
        transform.LookAt(target);
    }


}
