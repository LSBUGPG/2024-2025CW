using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float bulletLife = 1f;
    public float rotation = 0f;
    public float speed = 1f;

    private Vector2 spawnPoint;
    private float bulletTimer = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = new Vector2(transform.position.x, transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        if(bulletTimer > bulletLife)
        {
            GameObject.Destroy(gameObject);
        }
        bulletTimer += Time.deltaTime;
        transform.position = bulletMove(bulletTimer);
    }

    private Vector2 bulletMove(float bulletTimer)
    {
        float xMov = bulletTimer * speed * transform.right.x;
        float yMov = bulletTimer * speed * transform.right.y;
        return new Vector2(xMov + spawnPoint.x, yMov + spawnPoint.y);
    }
}
