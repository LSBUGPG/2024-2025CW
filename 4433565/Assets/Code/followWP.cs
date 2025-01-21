using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followWP : MonoBehaviour
{
    // created an array for the waypoints
    public GameObject[] waypoints;
    // starting number tends to be 0 instead of 1
    int currentWP = 0;

    public float speed = 100.0f;
    public float rotSpeed = 30.0f;

    void Start()
    {
        
    }

    void Update()
    {
        if (Vector3.Distance(this.transform.position, waypoints[currentWP].transform.position) < 10)
            currentWP++;

        //this.transform.LookAt(waypoints[currentWP].transform);

        Quaternion lookatWP = Quaternion.LookRotation(waypoints[currentWP].transform.position - this.transform.position);

        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, lookatWP, rotSpeed * Time.deltaTime);

        this.transform.Translate(0, 0, speed * Time.deltaTime);
    }
}
