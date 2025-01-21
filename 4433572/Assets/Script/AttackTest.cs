using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackTest : MonoBehaviour
{
    public float life;
    public PlayerHealtScript playerHealth;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        Destroy(gameObject, life);
        playerHealth = GameObject.Find("Player").GetComponent<PlayerHealtScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            playerHealth.playerCurrentHealth--;
            Destroy(gameObject);
        }
        Destroy(gameObject);
    }
}
