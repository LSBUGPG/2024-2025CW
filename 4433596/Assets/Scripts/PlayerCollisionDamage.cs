using Palmmedia.ReportGenerator.Core.Parser.Analysis;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionDamage : MonoBehaviour
{
    public Health healthSystem;
    public float collisionDamage = 10f;
    // Start is called before the first frame update
    void Start()
    {
        if (healthSystem == null)
        {
            // Try to find the Health system if it hasn't been set in the Inspector
            healthSystem = FindObjectOfType<Health>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*
    // This method is called when the player collides with another object
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the object the player collided with has the "DamageObject" tag
        if (collision.gameObject.CompareTag("Spike"))
        {
            // Apply damage by calling the takeDamage method on the Health system
            healthSystem.takeDamage(collisionDamage);
        }
    }
    */

    // Alternatively, if you are using triggers instead of colliders, use OnTriggerEnter

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.collider.CompareTag("Spike"))
        {
            healthSystem.takeDamage(collisionDamage);
        }
    }
}
