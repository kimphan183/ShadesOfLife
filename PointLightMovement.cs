using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointLightMovement : MonoBehaviour
{
    public float speed = 2.0f; // speed of the movement
    public float distance = 5.0f; // distance the light travels
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position; // save the starting position of the light
    }

    void Update()
    {
        // calculate the new position of the light based on the speed and distance
        float newPosition = Mathf.PingPong(Time.time * speed, distance);
        transform.position = startPosition + Vector3.up * newPosition; // move the light along the y-axis
    }
}
