using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    enum SpawnerType { Straight, Spin }

    [Header("Bullet Stats")]
    public GameObject bullet;
    public float bulletLife = 1f;
    public float speed = 1f;

    [Header("Spawner Stats")]
    [SerializeField] private SpawnerType spawnType;
    [SerializeField] private float fireRate = 1f;

    [Header("Difficulty Increase")]
    public float diffChange = 0f;
    private float diffRate = 60f;
    public int diffLevel = 0;

    private GameObject spawnedBullet;
    private float fireTimer = 0f;
    private float diffTimer = 0f;

    // Update is called once per frame
    void Update()
    {
        fireTimer += Time.deltaTime;
        diffTimer += Time.deltaTime;
        if (spawnType == SpawnerType.Spin)
        {
            transform.eulerAngles = new Vector3(0f, 0f, transform.eulerAngles.z + 1f);
        }
        
        if (fireTimer >= fireRate)
        {
            Shoot();
            fireTimer = 0;
        }

        if (diffTimer >= diffRate)
        {
            if (diffLevel < 10)
            {
                fireRate = fireRate - diffChange;
                diffTimer = 0;
                diffLevel += 1;
            }
        }
    }

    private void Shoot()
    {
        spawnedBullet = Instantiate(bullet, transform.position, Quaternion.identity);
        spawnedBullet.GetComponent<BulletMovement>().speed = speed;
        spawnedBullet.GetComponent<BulletMovement>().bulletLife = bulletLife;
        spawnedBullet.transform.rotation = transform.rotation;
    }
}
