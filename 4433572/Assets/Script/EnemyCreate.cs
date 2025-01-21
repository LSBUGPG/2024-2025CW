using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCreate : MonoBehaviour
{
    public GameObject enemySpawner;
    public GameObject enemyWalker;
    public GameObject enemyAttacker;
    public GameObject gate;
    public Transform spawning;
    public Transform spawning2;
    public bool s;
    public bool w;
    public bool a;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter()
    {
        if(w == true)
        {
            GameObject newWalker = Instantiate(enemyWalker, spawning.position, spawning.rotation);
            GameObject newWalker2 = Instantiate(enemyWalker, spawning2.position, spawning2.rotation);
            Destroy(gameObject);
        }
        if(s == true)
        {
            GameObject newSpawner = Instantiate(enemySpawner, spawning.position, spawning.rotation);
            GameObject newSpawner2 = Instantiate(gate, spawning2.position, spawning2.rotation);
            Destroy(gameObject);
        }
        if (a == true)
        {
            GameObject newAttacker = Instantiate(enemyAttacker, spawning.position, spawning.rotation);
            GameObject newAttacker2 = Instantiate(enemyAttacker, spawning2.position, spawning2.rotation);
            Destroy(gameObject);
        }

    }

}
