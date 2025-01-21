using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public float spawnRate;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", spawnRate, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        float yPos = Random.Range(-5f, 5f);
        float xPos = transform.position.x;
        Instantiate(enemy, new Vector3(xPos, yPos, 0), Quaternion.identity);
    }
}
