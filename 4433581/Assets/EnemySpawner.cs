using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public int counter;
    public GameObject[] Enemy;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0, 2f);
    }

    public void SpawnEnemy()
    {
        if (--counter == 0) CancelInvoke("SpawnEnemy");
        Instantiate(Enemy[Random.Range(0, Enemy.Length)], new Vector3(Random.Range(-46, 7), 1f, Random.Range(-25f, 25f)), Quaternion.identity);
    }
}

