using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    // This is called when this GameObject collides with another object
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("bullet"))
        {
            Destroy(gameObject);
        }
    }
}