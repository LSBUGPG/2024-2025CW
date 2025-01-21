using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollowSecond : MonoBehaviour
{
    public NavMeshAgent enemy;
    public GameObject player;
    Transform target;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("MainCamera");
        target = player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(target.position);
    }

}
//link to the video i took reference for the code https://www.youtube.com/watch?v=6Ai0xg6xTUk
