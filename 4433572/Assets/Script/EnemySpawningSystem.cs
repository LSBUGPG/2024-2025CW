using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawningSystem : MonoBehaviour
{
    public GameObject walkingEnemy;
    public Transform theSpawner;
    public float enemyTimer;
    public bool spawnAllowed = false;
    public int limit;
    public int setLimit;
    public GateScript gateScript;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawning());
        gateScript = GameObject.FindWithTag("Gate").GetComponent<GateScript>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (limit == setLimit)
        {
            spawnAllowed = false;
            gateScript.limitFinished = true;
        }

    }

    private IEnumerator spawning()
    {
        WaitForSeconds wait = new WaitForSeconds(enemyTimer);
        while(spawnAllowed == true && limit < setLimit)
        {
            yield return wait;
            GameObject newEnemy = Instantiate(walkingEnemy, new Vector3(Random.Range(-125f, -145f),18, Random.Range(55f,65f)), Quaternion.identity);
            limit++;
        }
    }
}
