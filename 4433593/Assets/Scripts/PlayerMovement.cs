using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float MoveSpeed = 10;
    [SerializeField] float MoveDelay = 10;
    static public bool dialouge = false;

    // Start is called before the first frame update
    void Start()
    {
        //this says to get the rigid body commponent when the scene plays
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!PlayerMovement.dialouge)
        {
            //this means that the float/ value put for the horizontal movement (horInput) uses the horizontal axis is multpied by the Movespeed same for the verInput
            float horInput = Input.GetAxisRaw("Horizontal") * MoveSpeed;
            float verInput = Input.GetAxisRaw("Vertical") * MoveSpeed;

            rb.velocity = new Vector3(horInput, 0, verInput);
            //cursor.visible = false;
        }
        //else //this just makes it so that when the character does interact with another npc the character is restrained in all axis and cannot move (uses the rigidbody).
        //{
            //rb.constraints =RigidbodyConstraints.FreezeAll;

            //cursor.visible = true;
        //}
    }
}
