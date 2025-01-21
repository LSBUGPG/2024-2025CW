using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float enemyMaxHealth;
    public float enemyCurrentHealth;
    public GameObject helper;
    SupportSpawnerSystem supportSpawner;
    // Start is called before the first frame update
    void Start()
    {
        enemyCurrentHealth = enemyMaxHealth;
        
    }
    private void Awake()
    {
        helper = GameObject.FindGameObjectWithTag("Supporter");
         supportSpawner = helper.GetComponent<SupportSpawnerSystem>();
    }
    // Update is called once per frame
    void Update()
    {
        if(enemyCurrentHealth == 0)
        {
            if(supportSpawner.jumperLimit < supportSpawner.supportMaxLimit)
            {
                supportSpawner.jumperLimit++;
            }
            if(supportSpawner.hoverLimit < supportSpawner.supportMaxLimit)
            {
                supportSpawner.hoverLimit++;
            }
            if (supportSpawner.runOut == true)
            {
                supportSpawner.runOut = false;

            }
            supportSpawner.jumperOff = false;
            supportSpawner.hoverOff = false;
            Destroy(gameObject);
        }
    }
    // I used a bit of code from this video: https://www.youtube.com/watch?v=vNL4WYgvwd8
}
