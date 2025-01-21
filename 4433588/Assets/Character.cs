using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float speed = 1;
    public bool Waiting = true;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(-8, 2, 0);
        StartCoroutine(Animate());
    }

    // Update is called once per frame
    IEnumerator Animate()
    {
        while (transform.position.x < 0)
        {
            transform.position += Vector3.right * Time.deltaTime * speed;
            yield return null;
        }
        while (Waiting)
        {
            yield return null;
        }
        while (transform.position.x > -8)
        {
            transform.position += Vector3.left * Time.deltaTime * speed;
            yield return null;
        }

        // show text
    }
}
