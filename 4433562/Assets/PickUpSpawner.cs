using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpSpawner : MonoBehaviour
{
    [Header("Health Pickup Details")]
    public GameObject healthPack;
    public float healthRate = 30f;
    private float healthTimer = 0f;

    [Header("Score Pickup Details")]
    public GameObject bronzeCoin;
    public GameObject silverCoin;
    public GameObject goldCoin;
    public float scoreRate = 10f;
    private float scoreTimer = 0f;
    private GameObject coinToSpawn;

    // Update is called once per frame
    void Update()
    {
        healthTimer += Time.deltaTime;
        scoreTimer += Time.deltaTime;

        if (healthTimer >= healthRate)
        {
            HealthSpawn();
            healthTimer = 0;
        }

        if (scoreTimer >= scoreRate)
        {
            ScoreSpawn();
            scoreTimer = 0;
        }
    }

    private void HealthSpawn()
    {
        float healthX = Random.Range(-8, 8);
        float healthY = Random.Range(-4, 4);
        Instantiate(healthPack, new Vector2(healthX, healthY), Quaternion.identity);
    }

    private void ScoreSpawn()
    {
        int coinChoice = Random.Range(0, 10);
        if (coinChoice <= 5)
        {
            coinToSpawn = bronzeCoin;
        }
        else if (coinChoice <= 8)
        {
            coinToSpawn = silverCoin;
        }
        else if (coinChoice <= 10)
        {
            coinToSpawn = goldCoin;
        }
        float scoreX = Random.Range(-8, 8);
        float scoreY = Random.Range(-4, 4);
        Instantiate(coinToSpawn, new Vector2(scoreX, scoreY), Quaternion.identity);
    }
}
