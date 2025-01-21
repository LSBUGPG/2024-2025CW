using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject apple;
    public Transform left;
    public Transform right;
    public float spawnRate;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnApple", 1f, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnApple()
    {
        float xpos=Random.Range(left.position.x, right.position.x);
        Vector2 pos=new Vector2(xpos, 6);
        Instantiate(apple, pos, Quaternion.identity);
    }
}
