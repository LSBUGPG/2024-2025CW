using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shutter : MonoBehaviour
{
    public bool Waiting;
    public float speed = 1;
    // Start is called before the first frame update


    // Update is called once per frame
    IEnumerator Start()
    {
        while (true)
        {
            while (Waiting)
            {
                yield return null;
            }
            while (transform.position.y > -0.04)
            {
                transform.position += Vector3.down * Time.deltaTime * speed;
                yield return null;
            }
            Waiting = true;
            while (Waiting)
            {
                yield return null;
            }
            while (transform.position.y < 5.84)
            {
                transform.position += Vector3.up * Time.deltaTime * speed;
                yield return null;
            }
            Waiting = true;
        }
    }
}
