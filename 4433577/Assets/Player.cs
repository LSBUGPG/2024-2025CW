using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
    private CharacterController controller;
    private Vector2 velocity;
    private bool grounded;

    public float speed = 10f;
    public float jump = 2f;
    private float gravity = -30f;

    int coins;

    // Start is called before the first frame update
    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    private void Update()
    {
        grounded = controller.isGrounded;

        if (grounded && velocity.y < 0)
        {
            velocity.y = 0f;
        }

        float forwardMovement = Input.GetAxis("Vertical");
        float sideMovement = Input.GetAxis("Horizontal");

        Move(forwardMovement, sideMovement);

        // This if statement is what controls the jumping 
        if (grounded && Input.GetKey(KeyCode.Space))
        {
            velocity.y = Mathf.Sqrt(jump * -2.5f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

    // Bellow is the code for the 3-dimentional movement
    private void Move(float forwardMovement, float sideMovement)
    {
        Vector2 moveForward = transform.forward * forwardMovement;
        Vector2 moveSide = transform.right * sideMovement;
        Vector2 totalMovement = moveForward + moveSide;
        Vector2 move = totalMovement * speed;

        controller.Move(move * Time.deltaTime);
    }
    public void AddCoin()
    {

        coins++;
        Debug.Log($"Coins collected: {coins}");
    }
}