using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerMove player = other.GetComponent<PlayerMove>();
        if (player != null )
        {
            player.AddGem();
            gameObject.SetActive(false);

                count--;
                if (count == 0)
             {
                 Debug.Log("You got them all!");
             }
        }
    }
    static int count = 0;
    void Start()
    {
        count++;
        
    }
}

