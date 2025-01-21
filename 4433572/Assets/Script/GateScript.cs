using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateScript : MonoBehaviour
{
    public EnemySpawningSystem enemySpawningSystem;
    public bool openTheGate;
    public int EnemyRequired;
    public bool limitFinished;
    // Start is called before the first frame update
    void Start()
    {
        limitFinished = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (limitFinished == true)
        {
            Destroy(gameObject);
        }
    }
}
