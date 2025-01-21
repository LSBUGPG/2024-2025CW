using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Rigidbody2D myRigidbody;
    public float JumpStrength;
    public Transform LeftSide;
    public Transform RightSide;
    public float Speed = 1f;
    private Transform CurrentTarget;
    // Start is called before the first frame update
    void Start()
    {
        CurrentTarget = LeftSide;
    }

    // Update is called once per frame
    void Update()
    {
        var step = Speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, CurrentTarget.position, step);

        if (Input.GetKeyDown(KeyCode.UpArrow) == true)
        {
            myRigidbody.velocity = Vector2.up * JumpStrength;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) == true)
        {
            myRigidbody.velocity = Vector2.left * JumpStrength;
            
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) == true)
        {
            myRigidbody.velocity = Vector2.right * JumpStrength;
            
        }
        if (Input.GetMouseButtonDown(0))
        {
            if (CurrentTarget == RightSide)
            {
                CurrentTarget = LeftSide;
            }
            else
            {
                CurrentTarget = RightSide;
            }
        }
        
    }
}
