using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationBehavior : MonoBehaviour
{
    [SerializeField]
    private float degreesPerSecond = 360f;

    [SerializeField]
    private Vector3 rotationAxis = Vector3.up;

    void Update()
    {
        transform.Rotate(rotationAxis * degreesPerSecond * Time.deltaTime);
    }
}
