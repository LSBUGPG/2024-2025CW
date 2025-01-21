using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class playerMovement : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed;

    public float originalSpeed;

    public float speedBoost = 2f;
    public float boostTime = 2f;
    public float groundDrag;
    public float jumpForce;
    public float jumpCooldown;
    public float airMultiplier;

    bool readyToJump;
    [Header("KeyBinds")]
    public KeyCode jumpKey = KeyCode.Space;

    [Header("Ground Check")]
    public float playerHeight;
    public LayerMask whatIsGround;
    bool grounded;

    public Transform orientation;

    float horizontalInput;
    float verticalInput;

    Vector3 moveDirection;

    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
        readyToJump = true;
        originalSpeed = moveSpeed;
    }

    private void Update()
    {
        // ground check
        grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.2f, whatIsGround);

        MyInput();

        // handle drag
        if (grounded)
            rb.linearDamping = groundDrag;
        else
            rb.linearDamping = 0;

        SpeedControl();

    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
        if(Input.GetKey(jumpKey) && readyToJump && grounded)
        {
            readyToJump = false; 

            Jump();

            Invoke(nameof(ResetJump), jumpCooldown);
        }

    }


    private void MovePlayer()
    {
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;

        if(grounded)
            rb.AddForce(moveDirection.normalized * moveSpeed * 10F, ForceMode.Force);

        else if(!grounded)
        {
            rb.AddForce(moveDirection.normalized * moveSpeed * 10F * airMultiplier, ForceMode.Force);
        }
        
    }

    private void SpeedControl()
    {
        Vector3 flatVel = new Vector3(rb.linearVelocity.x, 0f, rb.linearVelocity.z);


        if(flatVel.magnitude > moveSpeed)
        {
            Vector3 limitedVel = flatVel.normalized * moveSpeed;
            rb.linearVelocity = new Vector3(limitedVel.x, rb.linearVelocity.y, limitedVel.z);
        }
    }
    private void Jump()
    {
        rb.linearVelocity = new Vector3(rb.linearVelocity.x, 0f, rb.linearVelocity.z);

        rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
    }

    private void ResetJump()
    {
        readyToJump = true;
    }
    

private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "SpeedBoost")
        {
            StartCoroutine(ApplyBoost());
            Destroy(other.gameObject);
        }
    }

private IEnumerator ApplyBoost()
{
    moveSpeed *= speedBoost;
    yield return new WaitForSeconds(boostTime);
    moveSpeed = originalSpeed;
}

private void OnCollisionEnter(Collision collision)
{
    if(collision.gameObject.name == "Enemy")
    {
        Destroy(collision.gameObject);
    }
}

}
