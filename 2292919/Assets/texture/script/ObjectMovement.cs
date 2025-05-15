using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public float movementSpeed = 5f;
    public float rotationSpeed = 180f;
    public float jumpForce = 5f;
    public float groundDistance = 0.2f;
    public LayerMask groundMask;

    private bool isGrounded;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Check if the object is grounded
        isGrounded = Physics.CheckSphere(transform.position, groundDistance, groundMask);

        // Movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = (transform.forward * verticalInput + transform.right * horizontalInput) * movementSpeed * Time.deltaTime;
        rb.MovePosition(transform.position + movement);

        // Rotation
        float rotationInput = Input.GetAxis("Mouse X");
        Vector3 rotation = new Vector3(0f, rotationInput, 0f) * rotationSpeed * Time.deltaTime;
        rb.MoveRotation(rb.rotation * Quaternion.Euler(rotation));

        // Jumping
        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
        }
    }
}
