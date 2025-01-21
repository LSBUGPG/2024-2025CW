using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackScript : MonoBehaviour
{
    public GameObject attack;
    public float attackSpeed;
    public float attackTime;
    public float attackStart;
    public float attackWait;
    public Transform attackSpawning;
    public GameObject target;
    public Transform player;
    public Vector3 playerLocation;


    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("MainCamera");
        player = target.transform;
        InvokeRepeating("Attacker", attackStart, attackWait);
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player);
    }
    private void Attacker()
    {
        var shoot = Instantiate(attack,attackSpawning.position, attackSpawning.rotation);
        shoot.GetComponent<Rigidbody>().velocity = attackSpawning.forward * attackSpeed;
    }
    //this is where i got reference for some part of the code https://www.youtube.com/watch?v=6Ai0xg6xTUk
}
