using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.OpenXR;

public class CircularMotion : MonoBehaviour
{
    public float radius = 2f;
    public float speed = 0.4f;
    public Vector3 axis = Vector3.up;

    private Vector3 _originalPosition;

    void Start()
    {
        // Store the original position of the cube
        _originalPosition = transform.position;
    }

    void Update()
    {
        // Calculate the angle to rotate the cube
        float angle = Time.time * speed * 2 * Mathf.PI;

        // Calculate the new position of the cube in a circular path
        Vector3 offset = radius * (Mathf.Cos(angle) * axis.normalized + Mathf.Sin(angle) * Vector3.Cross(Vector3.up, axis.normalized));

        // Set the position of the cube to the new position
        transform.position = _originalPosition + offset;
    }
}
