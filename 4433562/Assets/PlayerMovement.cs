using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;
    public float originalSpeed;
    public float slowedSpeed;
    // Start is called before the first frame update
    void Start()
    {
        originalSpeed = speed;
        slowedSpeed = speed / 2;
    }

    // Update is called once per frame
    void Update()
    {
        //controls player movement
        if(Input.GetKey(KeyCode.LeftArrow) | Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow) | Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.UpArrow) | Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow) | Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }

        //slows down the player when the button is held down
        if (Input.GetKey(KeyCode.Z) | Input.GetKey(KeyCode.P))
        {
            speed = slowedSpeed;
        }
        if (Input.GetKeyUp(KeyCode.Z) | Input.GetKeyUp(KeyCode.P))
        {
            speed = originalSpeed;
        }
    }
}
