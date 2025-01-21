using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;      // Speed of movement
    public float lookSpeedX = 2f;     // Horizontal mouse look speed
    public float lookSpeedY = 2f;     // Vertical mouse look speed
    public float upDownRange = 60f;   // Camera vertical look limits

    private Camera playerCamera;      // Reference to the camera
    private float rotationX = 0f;     // Current vertical rotation
    private Vector3 moveDirection;    // Direction of movement

    private void Start()
    {
        playerCamera = Camera.main;   // Get the main camera

        // Lock the cursor for first-person experience
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        HandleMovement();
        HandleMouseLook();
    }

    // Handle player movement
    private void HandleMovement()
    {
        float moveX = Input.GetAxis("Horizontal");  // A/D or Left/Right arrow keys
        float moveZ = Input.GetAxis("Vertical");    // W/S or Up/Down arrow keys

        moveDirection = transform.right * moveX + transform.forward * moveZ;

        // Move the player
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime, Space.World);
    }

    // Handle mouse look for the camera
    private void HandleMouseLook()
    {
        float mouseX = Input.GetAxis("Mouse X") * lookSpeedX;  // Horizontal mouse movement
        float mouseY = Input.GetAxis("Mouse Y") * lookSpeedY;  // Vertical mouse movement

        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -upDownRange, upDownRange);  // Clamp vertical rotation

        // Rotate camera vertically
        playerCamera.transform.localRotation = Quaternion.Euler(rotationX, 0f, 0f);

        // Rotate the player horizontally (left and right)
        transform.Rotate(Vector3.up * mouseX);
    }
}