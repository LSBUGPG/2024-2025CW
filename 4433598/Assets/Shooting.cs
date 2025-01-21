using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    // Bullet prefab to spawn
    public GameObject bulletPrefab;
    // The point where bullets will spawn (can be the gun's muzzle)
    public Transform shootingPoint;
    // Bullet speed
    public float bulletSpeed = 20f;
    // Rate of fire (how quickly the player can shoot)
    public float fireRate = 0.5f;
    private float nextFireTime;

    void Update()
    {
        // Check if the player presses the fire button (mouse button or keyboard)
        if (Input.GetButton("Fire1") && Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + fireRate;
        }
    }

    // Shooting function
    void Shoot()
    {
        if (bulletPrefab && shootingPoint)
        {
            // Instantiate the bullet at the shooting point
            GameObject bullet = Instantiate(bulletPrefab, shootingPoint.position, shootingPoint.rotation);

            // Get the Rigidbody component of the bullet
            Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
            if (bulletRb)
            {
                // Add force to the bullet to make it move
                bulletRb.AddForce(shootingPoint.forward * bulletSpeed, ForceMode.VelocityChange);
            }
        }
    }
}