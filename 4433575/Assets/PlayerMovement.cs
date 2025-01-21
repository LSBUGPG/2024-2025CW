using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10;
    public float jumpForce = 5;
    //Rb Code By Buvesa Game Devlopment on Youtube
    private Rigidbody PlayerRb;

    float horizontal;
    float vertical;
    bool jump;

    int touchingGround;
    
    
    // Start is called before the first frame update
    void Start()
    {
        PlayerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        if (touchingGround > 0 && Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;
        }
    }

    void FixedUpdate()
    {
        PlayerRb.AddForce(horizontal * speed * transform.right);
        PlayerRb.AddForce(vertical * speed * transform.forward);

        //Jump Code By Buvesa Game Devlopment on Youtube
        if (jump)
        {
            PlayerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            jump = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            touchingGround++;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            touchingGround--;
        }
    }
}
