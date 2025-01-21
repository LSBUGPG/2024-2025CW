using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverScript : MonoBehaviour
{
    public float timer;
    public float timerSave;
    private float timeLimit = 0f;
    public bool switchOn;
    PlayerScript playerScript;
    public GameObject player;
    Rigidbody rb;
    private MeshRenderer mr;
    // Start is called before the first frame update
    void Start()
    {
        timerSave = timer;
        mr.enabled = false;
    }
    void Awake()
    {
        playerScript = player.GetComponent<PlayerScript>();
        rb = player.GetComponent<Rigidbody>();
        mr = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(switchOn == true)
        {
            playerScript.hoverActive = true;
            mr.enabled = true;
        }
        if(playerScript.hoverActive == true)
        {
            rb.isKinematic = true;
            rb.detectCollisions = false;
            timer -= Time.deltaTime;
        }

        if(timer <= timeLimit)
        {
            switchOn = false;
            playerScript.hoverActive = false;
            rb.isKinematic = false;
            rb.detectCollisions = true;
            mr.enabled = false ;

        }
        if(timer <= timeLimit)
        {
            timer = timerSave;
        }
    }
}
