using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Viewer : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float speed = 10f;
    public float smoothTime = 0.1f;
    private Vector3 velocity;
    void Update()
    {
        Vector3 targetPosition = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }

}
