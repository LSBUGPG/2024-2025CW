using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
    public float jump;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        Destroy(gameObject, timer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        GameObject newJump = collision.gameObject;
        Rigidbody rb = newJump.GetComponent<Rigidbody>();
        rb.AddForce(Vector3.up * jump);
    }
}
