using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerMovement : MonoBehaviour
{

    public float speed = 5f;
    private bool moveUp = true;

    // Update is called once per frame
    void Update()
    {
        if (moveUp == true)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
            if (gameObject.transform.position.y <= -5) //negative used because spawner is rotated upside down
            {
                moveUp = false;
            }
        }
        else if (moveUp == false)
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
            if (gameObject.transform.position.y >= 5) //positive used because spawner is rotated upside down
            {
                moveUp = true;
            }
        }
    }
}
