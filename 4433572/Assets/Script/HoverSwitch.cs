using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverSwitch : MonoBehaviour
{
    HoverScript hoverScript;

    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Awake()
    {
        hoverScript = GameObject.Find("HoverExtra").GetComponent<HoverScript>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        hoverScript.switchOn = true;
        Destroy(gameObject);
    }
}
