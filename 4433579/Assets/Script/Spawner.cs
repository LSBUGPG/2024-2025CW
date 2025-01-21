using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Enemy;
    public Transform LeftSide;
    public Transform RightSide;
    public float spawnRate;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", spawnRate, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        float xPos = Random.Range(LeftSide.position.x, RightSide.position.x);
        Vector3 Pos = new Vector3(xPos, transform.position.y, 0);
        Instantiate(Enemy, Pos, Quaternion.identity);
    }
}
